using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public float damage;
    Rigidbody2D bulletRD;

    void Start() //Eftersom detta �r i start funktionen s� kommer EnemyBullet bara beh�va r�kna det h�r en g�ng f�r att det ska g�lla
    {
        bulletRD = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");//Kollar p� Player
        Vector2 moveDire = (target.transform.position - transform.position).normalized * speed;//R�knar vart spelaren �r
        bulletRD.velocity = new Vector2(moveDire.x, moveDire.y);//R�r sig mot spelaren
        Destroy(this.gameObject, 2);
    }
}
