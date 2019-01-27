using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Game
{
    public static float timer;
    public static float timeMultiplier = 1;
    public static float endTime;
    public static Cat cat;
    public static UIController uiController;

    private static int clicks = 0;

    public static int totalClicks
    {
        get { return clicks; }
        set { clicks = value; checkUnlocks(); }
    }

    public static float getTimeRatio()
    {
        if(endTime == 0)
        {
            return 1;
        }

        return timer / endTime;
    }

    public static void PlaySoundEffect(AudioClip soundEffect)
    {
        GameObject.FindObjectOfType<AudioSource>().PlayOneShot(soundEffect);
    }

    public static Color getRandomColor()
    {
        Color color = Color.white;

        color.r = Random.Range(0.0f, 1.0f);
        color.g = Random.Range(0.0f, 1.0f);
        color.b = Random.Range(0.0f, 1.0f);

        return color;
    }

    private static void checkUnlocks()
    {
        if (clicks % 20 == 0)
        {
            if(clicks == 140)
            {
                PlaySoundEffect(cat.kamehameha);
            }

            if(clicks < 161)
            {
                uiController.buttons[(clicks / 20) - 1].SetActive(true);
                timeMultiplier *= 2.0f;
            }

            Time.timeScale = 0.1f;
            cat.Invoke("unpause", 0.15f);

            if(clicks == 160)
            {
                cat.gameObject.GetComponent<FinalSequence>().FinalEvent = true;
            }
        }
    }

    // restarts the game
    public static void Restart()
    {
        clicks = 0;
        timeMultiplier = 1;
        Time.timeScale = 1.0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        cat = null;
        uiController = null;
    }
}
