using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	//this script makes the camera follow the player
	//creates a 'soft' follow


	public NavMeshAgent navAgent;
	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		navAgent.destination = player.position;

	}
}
