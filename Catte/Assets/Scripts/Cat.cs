using System.Collections;
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

    public AudioClip kamehameha;

    [SerializeField]
    private Material[] catMaterials;

    [SerializeField]
    private Material[] pawMaterials;

    void Start ()
    {
        Game.endTime = timeLimit;
        Game.cat = this;

        int catType = Random.Range(0, 2);

        GetComponent<Renderer>().material = catMaterials[catType];
        GameObject.Find("Paw").GetComponent<Renderer>().material = pawMaterials[catType];
	}
	
	void Update ()
    {
        UpdateEyes();
        incrementTimer();

        // restart game with r (debug)
        if(Input.GetKeyDown(KeyCode.R))
        {
            Game.Restart();
        }
	}

    void incrementTimer()
    {
        Game.timer += Time.deltaTime * Game.timeMultiplier;
    }

    public void setEyeState(EYESTATE eyeState)
    {
        this.eyeState = eyeState;
    }

    public void unpause()
    {
        Time.timeScale = 1.0f;
    }

    void UpdateEyes()
    {
        GetComponentsInChildren<Renderer>()[1].material.mainTexture = eyeTextures[(int)eyeState];
        GetComponentsInChildren<Renderer>()[2].material.mainTexture = eyeTextures[(int)eyeState];
    }
}
