using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    Vector2 movement;
    bool isGrounded = false;
   
    public float jumpForce=250;
      // Start is called before the first frame update

    

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        rb.AddForce(movement*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space)&&isGrounded){
            rb.AddForce(Vector2.up * jumpForce);
        }
        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            isGrounded = false;
        }

    }

}
