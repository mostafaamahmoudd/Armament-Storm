using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    playerTakeDamage playerHealth;

    [SerializeField] private int bounsHealth = 5;
    [SerializeField] private collectablesSpawner1 cs;

    public healthBar hb;

    private void Awake()
    {
        playerHealth = FindObjectOfType<playerTakeDamage>();
        cs = FindObjectOfType<collectablesSpawner1>();
        hb = FindObjectOfType<healthBar>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (playerHealth.currentHealth < playerHealth.maxHealth)
        {
            playerHealth.currentHealth = playerHealth.currentHealth + bounsHealth;
            hb.SetHealth(playerHealth.currentHealth);
            cs.StartNewCoroutine(transform.position);
            Destroy(gameObject);
        }
    }
}
