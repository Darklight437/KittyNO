using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeHand : Distraction
{
    [SerializeField]
    private float pokeSpeed;

    [SerializeField]
    private float pokeDistance;

    private Vector3 center;
    private float createTime;

    new protected void Start()
    {
        base.Start();

        createTime = Time.time;
        center = transform.position;
    }

    private void Update()
    {
        float t = (Time.time - createTime) * pokeSpeed;
        transform.position = center + transform.right * Mathf.Sin(t) * pokeDistance;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position - transform.right * pokeDistance, transform.position + transform.right * pokeDistance);
    }
}
