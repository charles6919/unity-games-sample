using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBase<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                var obj = FindObjectOfType<T>();
                if (obj == null)
                {
                    GameObject newT = new GameObject(typeof(T).Name);
                    newT.AddComponent<T>();
                    instance = newT.GetComponent<T>();
                }
                else
                {
                    instance = obj.GetComponent<T>();
                }
            }

            return instance;
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(this);
    }
}
