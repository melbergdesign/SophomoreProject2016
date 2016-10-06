using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	//accessible number to control speed of the camera, 'tweakable' in the unity window
	public float speed = 1;
	private Vector3 tempPos;

		
	// Update is called once per frame
	void Update () {

		// Assigns new value to the x coordinate of the object's vector3 
		// Time.deltaTime forces the scene to update at a set rate rather than based on the FPS
		// Time continues to increase from the start of the game, multiplied by the speed value to evenly increment the distance
		// Since this is in Update, there are no big 'jumps' in the camera, adds distance to itself
		tempPos.x = speed * Time.deltaTime;

		//Accesses the Transform of the object this script is attached to
		//Translate Moves the transform in the direction and distance of translation
		// tempPos is the location data in the form of an (x,y,z) coordinate. Since nothing has been entered for the y and z, they default to 0.
		// x has been defined in the statement above and changes every frame due to being in the update function
		transform.Translate (tempPos);

	}
}
