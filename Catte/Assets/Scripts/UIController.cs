﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] distractions;

    // list of buttons to be enabled
    public GameObject[] buttons = new GameObject[8];

    private void Start()
    {
        Game.uiController = this;

        // disbale all the buttons
        for (int i = 0; i < 8; i++)
        {
            buttons[i] = GetComponentsInChildren<UnityEngine.UI.Image>()[i + 2].gameObject;
        }

        foreach(GameObject button in buttons)
        {
            button.SetActive(false);
        }
    }

    public void spawnDistraction(int id)
    {
        Game.totalClicks++;
        Instantiate(distractions[id]);
    }
}
