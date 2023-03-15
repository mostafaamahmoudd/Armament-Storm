using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] private float MovementSpeed = 2;
    private float distance;
    [SerializeField] private float distanceBetween = 10;

    void Start()
    {
        
    }


    void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direrction = Player.transform.position - transform.position;
        direrction.Normalize();
        float angle = Mathf.Atan2(direrction.y, direrction.x) * Mathf.Rad2Deg;

        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, MovementSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
