using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollider : MonoBehaviour
{
    public GameObject player;
    private Vector2 initialBoxColliderOffset;
    private bool lastFlipX;

    private void Start()
    {
        initialBoxColliderOffset = GetComponent<BoxCollider2D>().offset;
        lastFlipX = player.GetComponent<SpriteRenderer>().flipX;
    }

    private void Update()
    {
        bool currentFlipX = player.GetComponent<SpriteRenderer>().flipX;
        if (currentFlipX != lastFlipX)
        {
            transform.localScale = new Vector3(transform.localScale.x * 1, transform.localScale.y, transform.localScale.z);
            GetComponent<BoxCollider2D>().offset = new Vector2(-GetComponent<BoxCollider2D>().offset.x, GetComponent<BoxCollider2D>().offset.y);
            lastFlipX = currentFlipX;
        }
    }
}


