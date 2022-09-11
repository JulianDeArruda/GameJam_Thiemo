using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUpSound : MonoBehaviour
{

    private AudioSource audioSource;
    [SerializeField] AudioClip ItemPickUp;
    // Start is called before the first frame update
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void ItemSound()
    {
        AudioClip clip = ItemPickUp;
        audioSource.PlayOneShot(clip);
    }
}
