using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusicTransition : MonoBehaviour
{
    private static SceneMusicTransition instance;

    void Awake() //erm�glicht szenen unabh�ngikeit
    {
        if (instance = null)
        {
            instance = this;
            DontDestroyOnLoad(instance); //erm�glicht szenen unabh�ngikeit
        }
        else
        {
            Destroy(gameObject); //sorgt daf�r, dass es keine Dopplungen in der Musik gibt
        }
    }
}
