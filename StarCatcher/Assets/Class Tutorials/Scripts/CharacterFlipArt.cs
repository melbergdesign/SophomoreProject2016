using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {

    public Transform characterArt;
    //tests which way the art is facing
    public bool forward = true;

	void FlipCharacter (bool _b)
    {
        //same info in both ifs, so more concise in a function
        characterArt.Rotate(0, 180, 0);
        forward = _b;
    }
	
	void Update () {
        //listen for two events
        //&& forward means if forward is true
        if (Input.GetKeyDown(KeyCode.RightArrow) && forward)
        {
            FlipCharacter(false);
        }
        //listens for key pressed
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !forward)
        {
            FlipCharacter(true);
        }
    }
}
