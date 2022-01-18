using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTest : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 3;

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            Destroy(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            TakeDamage(1);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage (float Damage)
    {
        healthAmount -= Damage;
        healthBar.fillAmount = healthAmount / 3;
    }

}
