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
            //Här ska game over screen hända
        }

        if (Input.GetKeyDown(KeyCode.L))
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
