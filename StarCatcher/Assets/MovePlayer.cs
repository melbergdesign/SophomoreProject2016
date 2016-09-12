using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    public float speed = 10;
    //used to move the player
    private CharacterController controller;
    public float gravity = -9.81f;

    //used to asign location as a temp var
    private Vector3 tempPosition;
 

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //Fake gravity
        tempPosition.y = gravity;
        //Using Axis as an input with speed the character can hold or move L or R
        tempPosition.x = speed*Input.GetAxis("Horizontal");
        //regulates speed outside of fps
        tempPosition *= Time.deltaTime;
        //Move method takes the temp vector3 to move
        controller.Move(tempPosition);
	}
}
