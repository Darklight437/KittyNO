using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Game
{
    public static float timer;
    public static float timeMultiplier = 1;
    public static float endTime;

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
}
