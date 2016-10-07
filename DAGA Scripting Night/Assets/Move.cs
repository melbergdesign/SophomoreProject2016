using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	private float randomColorR = 0;
	private float randomColorG = 0;
	private float randomColorB = 0;

	public int intensity = 5;

	private bool isGrounded=true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //this references the object the script is attached to
            //GetComponent tells the script where to find the information you want to use
            //does not automatically know to use the Rigidbody without saying which one (the rigidbody on THIS object)
			this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.left*intensity;
         }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
			this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.right*intensity;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
			this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward*intensity;
        }

		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
		}

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
			this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.back*intensity;
        }

		if(isGrounded){

			if (Input.GetKeyDown(KeyCode.Space)){
				this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.up*intensity;
				isGrounded = false;
			}
				

			if (Input.GetKeyUp(KeyCode.Space))
			{
				this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
			}

		}

		if (Input.GetKeyUp(KeyCode.M))
		{
			MyFunction ();
		}
	}//end update

	void MyFunction()
	{
		//remember to put an 'f' after float #s
		randomColorR = Random.Range (0f, 1f);
		randomColorG = Random.Range (0f ,1f);
		randomColorB = Random.Range (0f ,1f);
		this.gameObject.GetComponent<MeshRenderer> ().material.color = new Color(randomColorR, randomColorG, randomColorB, 1);
	}

	//unity reserved function
	//Collision is a physics-based
	void OnCollisionEnter(Collision col)
	{
		//make sure to use quotes when signifying a tag
		if(col.gameObject.tag == "Ground")
		{
			isGrounded = true;
		}
	
			//"instantiate" key word
			//Character Controller is bad if you need custom actions or keys (doesn't use physics, so it moves oddly)
			//rigidbody is more customizable
	}

}