using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
  
    
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
}
