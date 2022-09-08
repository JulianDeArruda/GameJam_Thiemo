using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusicTransition : MonoBehaviour
{
    private static SceneMusicTransition instance;

    void Awake() //ermöglicht szenen unabhängikeit
    {
        if (instance = null)
        {
            instance = this;
            DontDestroyOnLoad(instance); //ermöglicht szenen unabhängikeit
        }
        else
        {
            Destroy(gameObject); //sorgt dafür, dass es keine Dopplungen in der Musik gibt
        }
    }
}
