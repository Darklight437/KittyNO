using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Vector3 startPosition;

    [Range(0.0f, 3.0f)]
    public float intensity;

	void Start ()
    {
        startPosition = transform.position;
	}
	
	void Update ()
    {
        transform.position = startPosition + Random.insideUnitSphere * intensity;
	}
}
