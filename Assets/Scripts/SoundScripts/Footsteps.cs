using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] metalClips;
    
    private AudioSource audioSource;
   

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    private void Step()
    {
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip()
    {
       

        
        {
           
                return metalClips[UnityEngine.Random.Range(0, metalClips.Length)];
           
        }

    }
}
