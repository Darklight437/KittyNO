using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yarn : Distraction
{


	// Use this for initialization
	new protected void Start ()
    {
        base.Start();
        GetComponent<Renderer>().material.color = Game.getRandomColor();
	}
	

}
