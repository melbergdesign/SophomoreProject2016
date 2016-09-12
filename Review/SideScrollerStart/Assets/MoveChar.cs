using UnityEngine;
using System.Collections;

public class MoveChar : MonoBehaviour {

    //This is the character controller component
    private CharacterController myCC;
    //Temp var of datatype vector3 to move the character
    private Vector3 tempPos;
    //Speed of the temp var in x
    public float speed = 5;
    public float gravity = -5;
    public float jumpSpeed = 50;
    public int jumpCount = 0;
    public int jumpCountMax = 2;


	// Use this for initialization
	void Start () {

        //This "finds" the character component
        myCC = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {

        //waiting for input and comparing jumpCount
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax-1)
        {
            //increments jumpCount by 1
            jumpCount++;
            //adding the jumpSpeed var to the tempPos var
            tempPos.y = jumpSpeed;
            
        }
        //test if the char controller is grounded
        if (myCC.isGrounded)
        {
            //reset jumpCount if grounded
            jumpCount = 0;
        }
        
        //adding the gravity var to the Y position of the tempPos Var
        tempPos.y -= gravity;
        //adding the speed var to the tempPos var x value with the R and L Arrow keys
        tempPos.x = speed*Input.GetAxis("Horizontal");
        //Moves the character controller at an even pace
        myCC.Move(tempPos * Time.deltaTime);
	
	}
}
