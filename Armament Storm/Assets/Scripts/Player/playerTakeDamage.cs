using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTakeDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    private Transform target;

    public healthBar hb;

    void Start()
    {
        target = GameObject.FindWithTag("Enemy").transform;
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);
    }

    void Update()
    {

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        hb.SetHealth(currentHealth);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
            Destroy(other.gameObject);
        }
    }
}
