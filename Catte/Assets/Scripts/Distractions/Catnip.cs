using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catnip : Distraction
{
    [SerializeField]
    private float spawnHeight;

    [SerializeField]
    private float tableHeight;

    [SerializeField]
    private float width;

    [SerializeField]
    private float fallSpeed;

    new protected void Start()
    {
        base.Start();

        // move to a random point above the screen
        transform.position = new Vector3(Random.Range(0, width) - width * 0.5f, spawnHeight, transform.position.z);
    }

    private void Update()
    {
        // fall until it hits the table
        if(transform.position.y > tableHeight)
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(Vector3.up * spawnHeight + Vector3.left * width * 0.5f, Vector3.up * spawnHeight + Vector3.right * width * 0.5f);
        Gizmos.DrawLine(Vector3.up * tableHeight + Vector3.left * width * 0.5f, Vector3.up * tableHeight + Vector3.right * width * 0.5f);
    }
}
