using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour
{
    private Transform paw;

    private Vector3 offset;

    private void Start()
    {
        // find the paw
        paw = GameObject.Find("Paw").transform;

        offset = transform.position - paw.position;
    }

    private void Update()
    {
        if(transform.position.x - paw.position.x > offset.x)
        {
            transform.position = paw.position + offset;
        }
    }
}
