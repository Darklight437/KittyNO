﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    private Transform paw;

    private Vector3 offset;

    [SerializeField]
    [Tooltip("When the object gets past this point on the x axis it is destroyed")]
    private float destroyPoint;

    [SerializeField]
    private AudioClip breakSound;

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

        if(transform.position.x <= destroyPoint)
        {
            Game.PlaySoundEffect(breakSound);
            Destroy(gameObject);
        }
    }
}
