using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{

    public float speed = 1;
    private Vector3 tempPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Updates position every frame
        tempPos.x = speed * Time.deltaTime;
        transform.Translate(tempPos);

    }
}