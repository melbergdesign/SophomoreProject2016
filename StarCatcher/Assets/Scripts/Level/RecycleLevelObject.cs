using UnityEngine;
using System.Collections;

public class RecycleLevelObject : MonoBehaviour {

    private Vector3 newLocation;

    void Start()
    {
        StaticVars.nextSectionPosition = 12;
    }

    void OnTriggerEnter()
    {
        newLocation.x = StaticVars.nextSectionPosition;
        transform.position = newLocation;
        StaticVars.nextSectionPosition += StaticVars.distance;

    }
}
