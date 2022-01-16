using UnityEngine;

public class Boss : MonoBehaviour
{
    public float attackcountdown = 3;
    public float attacktime;
    public Transform FirePointT;
    public Transform FirePointM;
    public Transform FirePointB;
    public GameObject BossthrowPrefab;

    public float BossHitPoints = 3;
    public float bossweakpoint = 5;

    public bool playerTooClose = false;
    void Start()
    {

    }


    void Update()
    {
        attacktime += Time.deltaTime;
        if (attacktime >= attackcountdown)
        {
            Shoot();
            attacktime = 0;
        }
    }

    void Shoot()
    {
        int random = Random.Range(0, 3);
        if (random == 0)
        {
            Instantiate(BossthrowPrefab, FirePointT.position, FirePointT.rotation);
        }
        else if (random == 1)
        {
            Instantiate(BossthrowPrefab, FirePointM.position, FirePointM.rotation);
        }
        else if (random == 2)
        {
            Instantiate(BossthrowPrefab, FirePointB.position, FirePointB.rotation);
        }



    }
    public void TakeDamage(int damage)
    {
        BossHitPoints -= damage;

        if (BossHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
