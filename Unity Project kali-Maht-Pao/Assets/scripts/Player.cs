using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    //how to define a variable
    //1. access modifier public or private
    //2. date type: int, float, bool. string
    //3. variable name: camelCase
    //4. value: optional

    public float playerSpeed = 6f;
    private float horizontalInput;
    private float verticalInput;

    private float horizontalScreenLimit =
    private float verticalScreenLimit =
        public GameObject bulletPrefab; 

    void Start()
    {
        //This function is called a the start of the game
       
    void update()
    {
        //This function is called every frame; 60 frames/second
        Movement()
        shooting()


    }
        void shootting()

        {
            //if the player presses the SPACE key, create a projectile
            if(horizontalInput.GetKeyDown(KeyCode.space))
        }

    void Movement()
    {
            //Read the input from the player
            horizontalInput = Input.GetAxis("Horizonttal");
        verticalInput = Input.GetAxis("Vertical");
        //Move the Player
         Transform.Translate(new Vector3(horizontalInput, 
             verticalInput, 0) *Time.deltaTime * playerspeed); 

        //Player leaves the screen horizontally
        if(Transform.position.x > horizontalScreenLimit || transform.position.x < -=horizontalScreenLimit)
            {
                 transform.position = new 
            }
   

    {
    
   
}


