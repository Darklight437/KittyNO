using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yarn : Distraction
{

	// Use this for initialization
	new protected void Start ()
    {
        base.Start();
        transform.position += Vector3.forward * Random.Range(0.0f, 3.0f);
        GetComponentInChildren<Renderer>().material.color = Game.getRandomColor();
	}
	

}
