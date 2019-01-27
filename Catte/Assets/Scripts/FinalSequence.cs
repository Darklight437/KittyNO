using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalSequence : MonoBehaviour
{
    [SerializeField]
    private GameObject Aura;
    [SerializeField]
    private GameObject EyeL;
    [SerializeField]
    private GameObject EyeR;

    private Vector3 eyeRPosition;
    private Vector3 eyeLPosition;

    public bool FinalEvent = false;
    private bool i = true;

    //increment this some how 

    private int clicksToWin = 30;
    private int currClicks = 0;

    private void Start()
    {
        eyeRPosition = EyeR.transform.position;
        eyeLPosition = EyeL.transform.position;
    }

    void Update ()
    {
        if (FinalEvent)
        {
            if (i)
            {
                //make eyes shake maddeningly
                EyeL.transform.position = eyeLPosition + (Vector3)Random.insideUnitCircle * 0.2f;
                EyeR.transform.position = eyeRPosition + (Vector3)Random.insideUnitCircle * 0.2f;
                
            }
            //make the cat super saiyan
            Aura.SetActive(true);

            if (currClicks == clicksToWin)
            {
                //GAME WON CLAUSE PUT VICTORY STUFF HERE
            }
        }
        
         i = !i;
	}
}
