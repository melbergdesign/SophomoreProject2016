using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarControl : MonoBehaviour {

    public List<Transform> spawners;
    public List<Transform> stars;

    void SpawnerHandler(Transform _t)
    {
        spawners.Add(_t);
    }

    void StarHandler(Transform _t)
    {
        stars.Add(_t);
    }

	// Use this for initialization
	void Start () {
        StarSpawner.SendSpawner += SpawnerHandler;
        Star.SendStar += StarHandler;
        //call the coroutine
        
        //coroutine is only called if there are stars in the game
        if(stars != null && spawners !=null)
        {
            StartCoroutine(Spawn());
        }
	}

    //make a spawning coroutine

    private bool canSpawn = true;
    //making room for more stars
    private int starNum;
    private int spawnerNum;

    IEnumerator Spawn ()
    {
        //repeating while true
        while (canSpawn)
        {
            //drops star and picks it back up after 1 sec
            yield return new WaitForSeconds(1);
            stars[starNum].position = spawners[spawnerNum].position;
            //art objects use "set active"
            stars[starNum].GetComponent<MeshRenderer>().enabled = true;
            //making room for more stars

            if (starNum < stars.Count-1)
            {
                starNum++;
            }
            else
            {
                starNum = 0;
            }
            if (spawnerNum < spawners.Count - 1)
            {
                spawnerNum++;
            }
            else
            {
                spawnerNum = 0;
            }
            //has to be below the if statement or it will set it to 1 before reseting to 0 and go out of range

        }
        
    }
	
}
