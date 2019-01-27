using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paw : MonoBehaviour
{
    [HideInInspector]
    public Vector3 TimeZeroPos;

    //finished position
    public Transform Time100Pos;

    [HideInInspector]
    public GameObject laser;

    //move from one to the other by moving linearly from pos0 to pos100 along X
    //by reading timer inside GameTimer, updating it by time and GameTimer's multiplier variable


    void Start ()
    {
        Game.paw = this;
        laser = transform.Find("Laser").gameObject;
        laser.SetActive(false);
        TimeZeroPos = transform.position;
    }

    //paw position & timer updating handled in fixedUpdate
    private void Update()
    {
        if(!Game.finalBattle)
        {
            transform.position = Vector3.Lerp(TimeZeroPos, Time100Pos.position, Game.getTimeRatio());
        }
    }
}
