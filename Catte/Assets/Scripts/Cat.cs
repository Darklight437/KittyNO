﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EYESTATE
{
    ANGRY,
    BORED,
    CLOSED,
    CONFUSED,
    DEAD,
    GARFIELD,
    GLASSES,
    HAPPY,
    ILLUMINATI,
    LARGE,
    LOVE,
    MONEY,
    NEUTRAL,
    REALISTIC,
    SAD,
    SLIT,
    SQUARE,
    SUGOI
}

public class Cat : MonoBehaviour
{
    
    public EYESTATE eyeState;

    [SerializeField]
    private List<Texture2D> eyeTextures;

    [SerializeField]
    private float timeLimit;

	void Start ()
    {
        Game.endTime = timeLimit;
	}
	
	void Update ()
    {
        UpdateEyes();
        incrementTimer();
	}

    void incrementTimer()
    {
        Game.timer += Time.deltaTime * Game.timeMultiplier;
    }

    void UpdateEyes()
    {
        GetComponentsInChildren<Renderer>()[1].material.mainTexture = eyeTextures[(int)eyeState];
        GetComponentsInChildren<Renderer>()[2].material.mainTexture = eyeTextures[(int)eyeState];
    }
}
