using UnityEngine;
using UnityEngine.SceneManagement;

public class Slash : MonoBehaviour
{
    //public Health hp;
    public int hp = 3;
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            SceneManager.LoadScene("DeathScreen");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // Gör så att obejektet med PlayerMovement alltså spelaren tar skada om den blir berörd av denna fiende. -Mattias
    {
        Move enemy = collision.transform.GetComponent<Move>();
        if (enemy != null)
        {
      //      enemy.TakeDamage(damage);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
