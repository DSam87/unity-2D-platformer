using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRb;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        // theRb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        theRb.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), theRb.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            theRb.velocity = new Vector2(theRb.velocity.x, jumpForce);
        }
    }


}
