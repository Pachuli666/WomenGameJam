using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody rb;

    public float playerVelocity = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float buttonHorizontal = Input.GetAxis("Horizontal");
        float buttonVertical = Input.GetAxis("Vertical") ;
        
        if(buttonHorizontal != 0){
              rb.velocity = new Vector3 (playerVelocity* buttonHorizontal, rb.velocity.y, rb.velocity.z);
        
        }else{
             rb.velocity = new Vector3 (0, rb.velocity.y, rb.velocity.z);
        }
        
        if(buttonVertical != 0){
        rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y , playerVelocity * buttonVertical);
        }else{

         rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, 0);
        }

        if(Input.GetKey(KeyCode.Space)){
            rb.velocity = new Vector3 (rb.velocity.x, playerVelocity, rb.velocity.z);
        }else{
         rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y , rb.velocity.z);
        }


    }
}
