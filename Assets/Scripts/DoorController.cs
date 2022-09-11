using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    
    public bool needsKey;
    public Sprechblasen _text;
    [SerializeField] public Sprite door_open;
    DoorSoundScript DoorAudio;  
   

    private void Awake()
    {
        
        _text = GetComponent<Sprechblasen>();
       DoorAudio = GetComponent<DoorSoundScript>();
        
    }

    public void Open()
    {
        if (needsKey)
        {
            if (Inventar.Singleton.isActive())
            {
                doorOpens();
                Inventar.Singleton.deactivateKey();
            }
            else
            {
                _text.setText("I need a Key!");
                _text.Activate();
            }
        }
        else
        {
            doorOpens();
        }
    }

    private void doorOpens()
    {
        DoorAudio.DoorSound();
        this.gameObject.SetActive(false);
      //  this.gameObject.GetComponent<SpriteRenderer>().sprite = door_open;
       // this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
       
    }

   
}
