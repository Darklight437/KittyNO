using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction : MonoBehaviour
{

    private float timerReduceAmt;
	// Use this for initialization
    void createDistraction()
    {

        reduceTimer(timerReduceAmt);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void reduceTimer(float reduceAmount)
    {
        Game.timer -= reduceAmount;
    }


    //no function should be nessecary for playing the animation as we can just play on awake


    //LIST OF DISTRACTION OBJECTS AS CURRENT
    //8 TOTAL
    //hand poke
    //hand pet
    //laser pointer
    //string
    //catnip
    //stick + bird (the bouncy toy on a string)
    //a cheezeburger OR loops (not sure which yet but obvious meme)
    //the spray bottle(simple particles)
    //
    //
    //each will have just one animation and only exist for a few seconds


}
