using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //ESTE SE USA PARA NO USAR RIGIDBODY Y PODER MOVER UN OBJETO
    private CharacterController controller;

    //VELOCIDAD DE MOVIMIENTO HORIZONTAL Y VERTICAL
    public float walkSpeed = 5f;

    //VELOCIDAD DE GIRO
    public float turnSpeed = 180f;

    void Start()
    {
       controller = GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movDir;

        //AQUI LE DECIMOS QUE CADA VEZ QUE GIRE EN SU PROPIO EJE LO HAGO CON LA VELOCIDAD DE LA VARIABLE TURNSPEED
        transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);

        //EL JUGADOR PUEDE DESPLAZARSE HACIA LOS LADOS
        movDir = transform.forward * Input.GetAxis("Vertical") * walkSpeed;
        
        //CONFIGURAMOS EL MOVIMIENTO TOTAL Y LA POSIBILIDAD DE SALTAR
        controller.Move(movDir * Time.deltaTime - Vector3.up * 0.1f);


        
        //float buttonHorizontal = Input.GetAxis("Horizontal");
        //float buttonVertical = Input.GetAxis("Vertical") ;
         
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
