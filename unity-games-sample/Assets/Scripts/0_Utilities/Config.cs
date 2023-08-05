using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour
{
#if UNITY_STANDALONE_WIN || UNITY_EDITOR
    
    public static string ip = ""; 

#elif UNITY_WEBGL

    public static string ip = "";

#endif
    
    public enum BuildMode
    {
        Debug = 0,
        Release = 1
    }

    public static BuildMode buildMode = BuildMode.Debug;
}
