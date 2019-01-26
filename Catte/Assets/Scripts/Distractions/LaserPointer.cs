using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : Distraction
{
    [SerializeField]
    private float laserDistance;

    [SerializeField]
    private float laserRadius;

    [SerializeField]
    private float randomOffsetRadius;

    new protected void Start ()
    {
        base.Start();
        transform.position += (Vector3)Random.insideUnitCircle * randomOffsetRadius;

        GetComponent<LineRenderer>().startColor = GetComponent<LineRenderer>().endColor = Game.getRandomColor();
        GetComponent<LineRenderer>().positionCount = 2;
        GetComponent<LineRenderer>().SetPosition(0, transform.position + transform.up * transform.localScale.y);
        GetComponent<LineRenderer>().SetPosition(1, transform.position + transform.up * (transform.localScale.y + laserDistance) + (Vector3)Random.insideUnitCircle * laserRadius);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position + transform.up * transform.localScale.y, transform.position + transform.up * (transform.localScale.y + laserDistance));
        Gizmos.DrawWireSphere(transform.position + transform.up * (transform.localScale.y + laserDistance), laserRadius);
    }
}
