using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

	//destination and agent variables needed
	public NavMeshAgent myAgent;
	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Agents ignore speed from rest of unity
		myAgent.destination = player.position;
	
	}
}
