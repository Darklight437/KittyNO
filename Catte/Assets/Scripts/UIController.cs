using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject petHand;

    [SerializeField]
    private GameObject pokeHand;

    [SerializeField]
    private GameObject laserPointer;

    [SerializeField]
    private GameObject yarn;

    public void spawnPetHand()
    {
        Instantiate(petHand);
    }

    public void spawnPokeHand()
    {
        Instantiate(pokeHand);
    }

    public void spawnLaserPointer()
    {
        Instantiate(laserPointer);
    }

    public void spawnYarn()
    {
        Instantiate(yarn);
    }
}
