using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class GameTimer
{
    public static float timer;
    public static float timeMultiplier = 1;
    public static float endTime;

    public static float getTimeRatio()
    {
        return timer / endTime;
    }
}
