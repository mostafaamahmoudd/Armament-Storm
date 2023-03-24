using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTakeDamage : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
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
        //if(transform.position.x >= target.transform.position.x)
        //{
        //    TakeDamage(5);
        //}
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
            TakeDamage(5);
            Destroy(other.gameObject);
        }
    }
}
