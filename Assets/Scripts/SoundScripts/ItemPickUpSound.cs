using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUpSound : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip ItemPickUp;
    
    
 

    // Update is called once per frame
    public void ItemSound()
    {
        AudioClip clip = ItemPickUp;
        audioSource.PlayOneShot(clip);
    }
}
