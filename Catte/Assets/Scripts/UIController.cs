using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject petHand;

    public void spawnPetHand()
    {
        Instantiate(petHand);
    }
}
