using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paw : MonoBehaviour {
    [SerializeField]
    private Transform TimeZeroPos;
    [SerializeField]
    private Transform Time100Pos;

    //move from one to the other by moving linearly from pos0 to pos100 along X
    //by reading timer inside GameTimer, updating it by time and GameTimer's multiplier variable


    void Start ()
    {
		
	}

    //paw position & timer updating handled in fixedUpdate
    private void FixedUpdate()
    {
        
    }

}
