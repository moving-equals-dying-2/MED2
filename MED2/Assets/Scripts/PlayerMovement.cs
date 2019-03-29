using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
     [SerializeField]private string horizontalInputName;    //skapar en variabel för horizontal
     [SerializeField]private float movementSpeed; //skapar en variabel för movementSpeed

    private CharacterController charController;    // skapar en variabel för character controller

    private void Awake()        // är en funktion som gör så att vi kan få tag på charactercontroller 
        {
            //charController = GetComponent<CharacterController>();      // hämtar character controller  
        }
    private void Update()
    {
        //PlayerMove();
    }
    private void PlayerMove()       // är en funktion för rörelse 
    {
        //float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed; // skapar en lokal variabel för horizantal multiplicerat med vår speed. 

        //Vector2 rightMovement = transform.right * horizInput;

        //charController.SimpleMove(rightMovement);

    }
}