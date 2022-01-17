using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private int bombDamage;

    [SerializeField] private HealthController _healthController;

    private void nTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        _healthController.playerHealth = _healthController.playerHealth - bombDamage;
        _healthController.UpdateHealth();
        gameObject.SetActive(false); 
    }
}
