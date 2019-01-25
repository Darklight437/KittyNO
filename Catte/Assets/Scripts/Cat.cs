using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum EYESTATE
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
    SUGOI
}

public class Cat : MonoBehaviour
{
    [SerializeField]
    private EYESTATE eyeState;

    [SerializeField]
    private List<Texture2D> eyeTextures;

    [SerializeField]
    private float timeLimit;

	void Start ()
    {
        GameTimer.endTime = timeLimit;
	}
	
	void Update ()
    {
        UpdateEyes();
        incrementTimer();
	}

    void incrementTimer()
    {
        GameTimer.timer -= Time.deltaTime * GameTimer.timeMultiplier;
    }

    void UpdateEyes()
    {
        GetComponentsInChildren<Renderer>()[1].material.mainTexture = eyeTextures[(int)eyeState];
        GetComponentsInChildren<Renderer>()[2].material.mainTexture = eyeTextures[(int)eyeState];
    }
}
