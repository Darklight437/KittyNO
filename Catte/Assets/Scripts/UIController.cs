using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject petHand;

    [SerializeField]
    private GameObject pokeHand;

    public void spawnPetHand()
    {
        Instantiate(petHand);
    }

    public void spawnPokeHand()
    {
        Instantiate(pokeHand);
    }
}
