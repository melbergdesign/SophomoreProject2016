using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour {


	public int forceTime = 10;
	public float forceDuration = 0.1f;
	//private bool canAddForce = true;
	private Rigidbody rigid;

	public float forceRange = 10;
	private Vector3 forceVector;
	private Vector3 torqueVector;

	public float torqueRange = 2;

	void Start(){
		rigid = GetComponent<Rigidbody> ();
		StartCoroutine (RunRandomForce());
	}

	IEnumerator RunRandomForce(){


		while (forceTime>0){
		//while (canAddForce) {
			yield return new WaitForSeconds (forceDuration);
			forceVector.x = Random.Range (-forceRange, forceRange);
			torqueVector.z = Random.Range (-torqueRange, torqueRange);
			rigid.AddForce (forceVector);
			forceTime--;
		}
	}

	public float endTime = 5;

	/*void Start(){
		GetComponent<Rigidbody> ().AddExplosionForce (200, transform.position, 20);
	}*/

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
