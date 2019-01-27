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

    private GameObject[] eyes = new GameObject[2];
    private Vector3[] eyePositions = new Vector3[2];

    [SerializeField]
    private List<Texture2D> eyeTextures;

    [SerializeField]
    private float timeLimit;

    public AudioClip finalBattleMusic;
    public AudioClip kamehameha;

    [SerializeField]
    private Material[] catMaterials;

    [SerializeField]
    private Material[] pawMaterials;

    [SerializeField]
    private GameObject explosionPrefab;

    [SerializeField]
    private AudioClip ExplosionFX;

    void Start ()
    {
        Game.endTime = timeLimit;
        Game.cat = this;

        // get references to eyes
        eyes[0] = GetComponentsInChildren<Renderer>()[1].gameObject;
        eyes[1] = GetComponentsInChildren<Renderer>()[2].gameObject;

        // store eyes start positions
        eyePositions[0] = eyes[0].transform.position;
        eyePositions[1] = eyes[1].transform.position;

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

    public void setEyeState(EYESTATE newState)
    {
        eyeState = newState;
    }

    public void unpause()
    {
        Time.timeScale = 1.0f;
    }

    public void spawnExplosion()
    {
        GameObject tempExplosion = Instantiate<GameObject>(explosionPrefab,transform.position + ((Vector3)Random.insideUnitCircle * 5), Quaternion.identity);
        Destroy(tempExplosion, 0.9f);
        Game.PlaySoundEffect(ExplosionFX);
    }

    public void UpdateEyes()
    {
        if(!Game.finalBattle)
        {
            eyes[0].GetComponent<Renderer>().material.mainTexture = eyeTextures[(int)eyeState];
            eyes[1].GetComponent<Renderer>().material.mainTexture = eyeTextures[(int)eyeState];
        }
    }

    void moveEyes()
    {
        eyes[0].transform.position = eyePositions[0] + (Vector3)Random.insideUnitCircle * 0.2f;
        eyes[1].transform.position = eyePositions[1] + (Vector3)Random.insideUnitCircle * 0.2f;
    }
}
