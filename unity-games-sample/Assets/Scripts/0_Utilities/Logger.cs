using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public static void Log(object message)
    {
        if(Config.buildMode == Config.BuildMode.Debug)
            Debug.Log(message);
    }

    public static void LogError(object message)
    {
        Debug.LogError(message);
    }

    public static void LogWarning(object message)
    {
        if(Config.buildMode == Config.BuildMode.Debug)
            Debug.LogWarning(message);
    }
}
