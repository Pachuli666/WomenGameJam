using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //ESTE SE USA PARA NO USAR RIGIDBODY Y PODER MOVER UN OBJETO
    private CharacterController controller;

    public float playerVelocity = 5f;

    void Start()
    {
       controller = GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movDir;
        
        float buttonHorizontal = Input.GetAxis("Horizontal");
        float buttonVertical = Input.GetAxis("Vertical") ;
         
        //if(buttonHorizontal != 0){
        //      rb.velocity = new Vector3 (playerVelocity* buttonHorizontal, rb.velocity.y, rb.velocity.z);
        
        //}else{
        //     rb.velocity = new Vector3 (0, rb.velocity.y, rb.velocity.z);
        //}
        
        //if(buttonVertical != 0){
        //rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y , playerVelocity * buttonVertical);
        //}else{

        // rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, 0);
        //}

    }
}
