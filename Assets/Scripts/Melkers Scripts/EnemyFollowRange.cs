using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowRange : MonoBehaviour
{
    public float speed;
    public float lineOfSite; //Hur st�r enemyns syn �r
    private Transform player; //Det som enemyn ska f�lja efter

    public float shootingRange;
    public float fireRate = 1f; 
    private float nextFireTime;

    public GameObject bullet;
    public GameObject bulletParent;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; //Letar efter spelaren och dess transform v�rde
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);//Enemyn f�ljer spelaren n�r den �r i n�rheten
        if (distanceFromPlayer < lineOfSite && distanceFromPlayer>shootingRange)//Om spelaren �r inanf�r dess syn men ocks� �r utanf�r shootingRange
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime); //R�r sig mot spelaren med en viss hastighet
        }
        else if (distanceFromPlayer<shootingRange && nextFireTime <Time.time)//Om spelaren �r innanf�r shootingRange och 
        {
            Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);//Skapar en bullet vid bulletParent. Ingen rotation
            nextFireTime = Time.time + fireRate;//Hur ofta enemyn kan skjuta
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite); //Skapar en cirkel runt om enemyn
        Gizmos.DrawWireSphere(transform.position, shootingRange); //Skapar en cirkel runt om enemyn
    }
}
