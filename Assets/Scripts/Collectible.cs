using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
  
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
       
        audioSource.Play();
    }

    
}
