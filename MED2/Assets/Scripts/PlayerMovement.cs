using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
   public float speed;

   private Rigidybody2D rb;
   private Vector2 moveVelocity;

   void start() {
       rb = GetComponent<Rigidybody2D>();
   }

   void update() {
       vector2 moveInput = new Vector2(moveInput.GetAxis("Horizontal")); 
       moveVelocity = moveInput * speed; 
   }    
}
