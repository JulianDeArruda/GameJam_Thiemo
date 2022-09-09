using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    
    public bool needsKey;
    public Sprechblasen _text;
    [SerializeField] public Sprite door_open;
   

    private void Awake()
    {
        
        _text = GetComponent<Sprechblasen>();
        _text.setText("I need a Key!");
    }

    private void Open()
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
        this.gameObject.GetComponent<SpriteRenderer>().sprite = door_open;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

   
}
