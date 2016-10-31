using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour {

	public int[] levelScores = {35, 16, 90, 12};

	// Use this for initialization
	void Start () {

		levelScores [2] = 28;

		for (int i = 0; i < levelScores.Length; i++)
		{
			int currentLevel = i+1;
			//currentLevel can only be used in the for loop
			print ("In level " + currentLevel + " you earned " + levelScores[i] + " points.");
		}


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
