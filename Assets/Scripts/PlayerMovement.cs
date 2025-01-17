using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float jumpPower = 15f;
    public int extraJumps = 1;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform feet;

    int jumpCount = 0;
    bool isGrounded;
    float mx;
    float jumpCoolDown;

    public float dashDistance = 15f;
    bool isDashing;
    float doubleTapTime;
    KeyCode lastKeyCode;

    float dashCoolDown;

    private void Update()
    {
        mx = Input.GetAxis("Horizontal");

        if (dashCoolDown > 0)
        {
            dashCoolDown -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        //dash �t v�nster
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (doubleTapTime > Time.time && lastKeyCode == KeyCode.A && dashCoolDown <= 0)
            {
                StartCoroutine(Dash(-1f));
            } else
            {
                doubleTapTime = Time.time + 0.5f;
            }

            lastKeyCode = KeyCode.A;
        }

        //dash �t h�ger
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (doubleTapTime > Time.time && lastKeyCode == KeyCode.D && dashCoolDown <= 0)
            {
                StartCoroutine(Dash(1f));
            }
            else
            {
                doubleTapTime = Time.time + 0.5f;
            }

            lastKeyCode = KeyCode.D;

        }


        CheckGrounded();
    }




    private void FixedUpdate()
    {
        if (!isDashing)
        rb.velocity = new Vector2(mx * speed, rb.velocity.y);
    }

    void Jump ()
    {
        if (isGrounded || jumpCount < extraJumps)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpCount++;
        }
    }

    void CheckGrounded ()
    {
        if (Physics2D.OverlapCircle(feet.position, 0.5f, groundLayer))
        {
            isGrounded = true;
            jumpCount = 0;
            jumpCoolDown = Time.time + 0.2f;
        } else if (Time.time < jumpCoolDown)
        {
            isGrounded = true;
        } else
        {
            isGrounded = false;
        }
        
    }

   IEnumerator Dash (float direction)
    {
        dashCoolDown = 3;
        isDashing = true;
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(new Vector2(dashDistance * direction, 0f), ForceMode2D.Impulse);
        float gravity = rb.gravityScale;
        rb.gravityScale = 0;
        yield return new WaitForSeconds(0.4f);
        isDashing = false;
        rb.gravityScale = gravity;
    }
}
