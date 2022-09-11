using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

   private AudioSource audioSource;
    [SerializeField] AudioClip ItemPickUp;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Collect()
    {
       
            if (gameObject.tag == "oil")
            {
                CharacterController.Instance.addOil(30);
            }
            if (gameObject.tag == "Key")
            {
                Inventar.Singleton.activateKey();
            }
        ItemSound();
            Destroy(this.gameObject);
        
    }

    public void weiter()
    {
       if (gameObject.tag == "Letter")
             {
            TexteundDialoge _text = GetComponent<TexteundDialoge>();
            _text.Activate();
            
             }
    }

    public void ItemSound()
    {
        AudioClip clip = ItemPickUp;
        audioSource.PlayOneShot(clip);
    }
}
