using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour {

	public float endTime = 5;

	void OnCollisionEnter () {
		Destroy (gameObject, endTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//IEnumerator EndStar(){

	//}

	// Use this for initialization
}
