using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject target;
    public float speed;
    Rigidbody2D bulletRD;

    void Start()
    {
        bulletRD = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDire = (target.transform.position - transform.position).normalized * speed;
        bulletRD.velocity = new Vector2(moveDire.x, moveDire.y);
        Destroy(this.gameObject, 2);
    }
}
