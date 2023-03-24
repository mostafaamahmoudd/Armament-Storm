using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    public SpriteRenderer sP;
    public BoxCollider2D Box;
    bool facingRight = true;
    public float moveSpeed;
    public Rigidbody2D rB;
    private Vector2 moveDirection;
    private void Update()
    {
        ProcessInputs();
        Attacking();
    }
    void FixedUpdate()
    {
        Move();
      
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        if(moveDirection.magnitude > 0.002)
        {
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }

        if (moveX < 0 && facingRight)
        {

            GetComponent<SpriteRenderer>().flipX = true;
            facingRight = false;

        }
        else if (moveX > 0 && !facingRight)
        {

            GetComponent<SpriteRenderer>().flipX = false;
            facingRight = true;
        }






    }

    void Move()
    {
        rB.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        
    } 

    public void Attacking()
    {

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("IsAttacking", true);

            DoAttack();

        }
        else
        {

            anim.SetBool("IsAttacking", false);

        }
    }
    public void DoAttack()
    {
        Box.enabled = true;
        StartCoroutine(HideCollider());
    }
    IEnumerator HideCollider()
    {
        yield return new WaitForSeconds(0.5f);
        Box.enabled = false;

    }

}
