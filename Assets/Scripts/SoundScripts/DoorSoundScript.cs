using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSoundScript : MonoBehaviour
{

    private AudioSource audioSource;
    [SerializeField] AudioClip DoorOpens;
    // Start is called before the first frame update
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void DoorSound()
    {
        AudioClip clip = DoorOpens;
        audioSource.PlayOneShot(clip);
    }
}
