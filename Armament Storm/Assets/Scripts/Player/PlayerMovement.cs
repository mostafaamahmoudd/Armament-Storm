using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;



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
        
       
            
          
        
    }

    void Move()
    {
        rB.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        
    } 

}
