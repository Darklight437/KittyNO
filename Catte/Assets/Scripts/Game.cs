using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Game
{
    public static float timer;
    public static float timeMultiplier = 1;
    public static float endTime;
    public static Cat cat;
    public static Paw paw;
    public static UIController uiController;

    // time that the final event started
    public static bool finalBattle = false;
    private static float finalBattleStart;

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

                // activate laser
                GameObject.Find("Final Laser").transform.position += Vector3.right * 20.0f;
            }

            if(clicks < 161)
            {
                uiController.buttons[(clicks / 20) - 1].SetActive(true);
                Time.timeScale = 0.1f;
                cat.Invoke("unpause", 0.15f);
                timeMultiplier *= 2.0f;
            }

            if(clicks == 160)
            {
                finalBattleStart = Time.time;
                finalBattle = true;

                // enable aura
                cat.GetComponentInChildren<SpriteRenderer>(true).gameObject.SetActive(true);

                // enable eye shake
                cat.setEyeState(EYESTATE.ANGRY);
                cat.InvokeRepeating("moveEyes", 0.0f, 1.0f / 30.0f);

                // enable camera shake
                Camera.main.GetComponent<CameraShake>().intensity = 0.1f;

                // disable final laser particle system
                ParticleSystem.EmissionModule p = GameObject.Find("Final Laser").GetComponent<ParticleSystem>().emission;
                p.enabled = false;

                // enable the laser cylinder
                paw.laser.SetActive(true);

                // disable breakable objects
                GameObject.Find("Breakable Things").SetActive(false);

                Camera.main.GetComponent<AudioSource>().clip = cat.finalBattleMusic;
                Camera.main.GetComponent<AudioSource>().Play();
                Time.timeScale = 0.1f;
                cat.Invoke("unpause", 1.0f);
            }
        }

        // final battle
        if(finalBattle)
        {
            float t = Time.time - finalBattleStart;

            float sn = Mathf.Sin(t) * 0.5f + 0.5f;

            paw.transform.position = Vector3.Lerp(paw.TimeZeroPos, paw.Time100Pos.position, sn);

            cat.spawnExplosion();

            //Finished
            if (clicks == 190)
            {
                Application.Quit();
            }
        }
    }

    // restarts the game
    public static void Restart()
    {
        clicks = 0;
        timer = 0;
        timeMultiplier = 1;
        Time.timeScale = 1.0f;
        finalBattle = false;
        finalBattleStart = 0;
        cat = null;
        paw = null;
        uiController = null;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
