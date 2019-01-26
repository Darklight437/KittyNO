using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction : MonoBehaviour
{
    [SerializeField]
    private float timerReduceAmt;
    [SerializeField]
    private EYESTATE eyeState;
    [SerializeField]
    private float lifetime;

    protected void Start()
    {
        Destroy(gameObject, lifetime);
        reduceTimer(timerReduceAmt);
        Game.cat.setEyeState(eyeState);
    }
	

    private void reduceTimer(float reduceAmount)
    {
        Game.timer = Mathf.Max(0, Game.timer - timerReduceAmt);
    }
}
