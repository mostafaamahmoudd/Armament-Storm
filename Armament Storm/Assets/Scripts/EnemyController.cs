using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public ScoreSystem ss;
    void Start()
    {
        ss = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerSword"))
        {
            ss.killsNum++;
            Destroy(gameObject);
        }
        
    }
}
