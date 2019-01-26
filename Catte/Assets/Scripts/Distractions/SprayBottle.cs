using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayBottle : Distraction
{
    [SerializeField]
    private float sprayRadius;

    private Vector3 startPos = Vector3.zero;

    new protected void Start()
    {
        base.Start();
        startPos = transform.position;
        InvokeRepeating("Spray", 0.0f, 0.5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, sprayRadius);
    }

    void Spray()
    {
        float randomAngle = Random.Range(0, 360.0f);

        transform.position = startPos;

        transform.rotation = Quaternion.Euler(0, 0, randomAngle);

        transform.position += transform.right * sprayRadius;
    }
}
