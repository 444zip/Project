using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic instance; // Create a static instance variable

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Use gameObject here to keep this object in the scene
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instance
        }
    }
}
