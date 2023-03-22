using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Animator anim;
    public CircleCollider2D circle;
    private void Start()
    {
        circle.enabled = false;
    }
    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {


        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("IsAttacking", true);
            circle.enabled = true;
           
        }
        else
        {
            anim.SetBool("IsAttacking", false);
            circle.enabled = false;
        }
           

    }
}
