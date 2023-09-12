using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    Vector2 movement;
    bool isGrounded = false;


   Touch touch;
    Vector2 startPos;
   public bool goLeft;
   public bool goRight;
    public float jumpForce=250;
      // Start is called before the first frame update

    

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // movement.x = Input.GetAxis("Horizontal");
        rb.AddForce(movement*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space)&&isGrounded){
            rb.AddForce(Vector2.up * jumpForce);
            FindObjectOfType<AudioManager>().Play("Jump");
            
        }
        if(Input.touchCount > 0){
        touch = Input.GetTouch(0);
        switch(touch.phase){
            case TouchPhase.Began:
                startPos = touch.position;
                break;

            case TouchPhase.Moved:
                Vector2 moveDir = touch.position - startPos;
                if(moveDir.x < 0){
                    movement.x = -1;
                }
                if(moveDir.x > 0){
                    movement.x = 1;
                }
                break;

            case TouchPhase.Ended:
                movement.x = 0;
                break;
        }
        }

    }

public void Jump(){
    if(isGrounded){
        rb.AddForce(Vector2.up * jumpForce);
        FindObjectOfType<AudioManager>().Play("Jump");
    }
}


private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.CompareTag("Ground")){
        isGrounded = true;
        FindObjectOfType<AudioManager>().Play("Fall");
    }
}

private void OnCollisionExit2D(Collision2D other) {
    if(other.gameObject.CompareTag("Ground")){
        isGrounded = false;
        
    }
}

}
