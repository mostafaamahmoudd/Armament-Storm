using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    public SpriteRenderer sP;

    bool facingRight = true;
    public float moveSpeed;
    public Rigidbody2D rB;
    private Vector2 moveDirection;
    private void Update()
    {
        ProcessInputs();
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

}
