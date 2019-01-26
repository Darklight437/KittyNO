using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction : MonoBehaviour
{
    [SerializeField]
    private float timerReduceAmt;
    [SerializeField]
    private EYESTATE eyeState;
    [SerializeField]
    private float lifetime;

    protected void Start()
    {
        Destroy(gameObject, lifetime);
        reduceTimer(timerReduceAmt);
        Game.cat.setEyeState(eyeState);
    }
	

    private void reduceTimer(float reduceAmount)
    {
        Game.timer = Mathf.Max(0, Game.timer - timerReduceAmt);
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
