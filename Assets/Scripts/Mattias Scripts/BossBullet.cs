using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public float speed = 3;
    public Rigidbody2D rb;
    public int damage = 1;

    public float timer;
    public float Deathcountdown = 10;
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void Update()
    {
       /* timer += Time.deltaTime;
        if (timer >= Deathcountdown)
        {
            Destroy(gameObject);       
        }*/
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Boss Ramses = hitInfo.transform.GetComponent<Boss>();
        if (Ramses != null)
        {
            Ramses.TakeDamage(damage);

        }
    }
}

