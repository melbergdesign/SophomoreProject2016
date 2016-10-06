using UnityEngine;
using System.Collections;

public class MoveChar : MonoBehaviour {

	//Creates a new instance of the Character Controller for this object
	//Character Controller is a built-in component of Unity
	private CharacterController myCC;
	private Vector3 tempPos;


	// Use this for initialization
	void Start () {

		//This "finds" the Character Controller component
		//GetComponent is the primary way of accessing other components 
		myCC = GetComponent<CharacterController> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
