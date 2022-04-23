using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRb;
    public float jumpForce;

    private bool isGrounded;
    private bool anotherJump;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;

    // Start is called before the first frame update
    void Start()
    {
        // theRb = gameObject.GetComponent<Rigidbody2D>();
        anotherJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        theRb.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), theRb.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);

        if(Input.GetButtonDown("Jump"))
        {

            if(isGrounded)
            {
                theRb.velocity = new Vector2(theRb.velocity.x, jumpForce);
                anotherJump = true;
            }
            else
            {
                if(anotherJump == true)
                {
                    anotherJump = false;
                    theRb.velocity = new Vector2(theRb.velocity.x, jumpForce);                
                }
            }
        }
    }


}
