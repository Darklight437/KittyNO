using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetHand : Distraction
{
    [SerializeField]
    private float petRadius;

    [SerializeField]
    private float petSpeed;


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
        float t = (Time.time - createTime) * petSpeed;
        transform.position = center + new Vector3(Mathf.Sin(t), Mathf.Cos(t), 0) * petRadius;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, petRadius);
    }
}
