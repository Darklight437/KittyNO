using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdOnStick : Distraction
{
    [SerializeField]
    private float screenLeft;

    [SerializeField]
    private float minHeight;

    [SerializeField]
    private float maxHeight;

    [SerializeField]
    private float moveSpeed;

    new protected void Start()
    {
        base.Start();

        // move to a random height left of the screen
        transform.position = new Vector3(screenLeft, Random.Range(minHeight, maxHeight), transform.position.z);
    }

    private void Update()
    {
        // move right
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.World);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(new Vector3(screenLeft, minHeight, transform.position.z), new Vector3(screenLeft, maxHeight, transform.position.z));
    }
}
