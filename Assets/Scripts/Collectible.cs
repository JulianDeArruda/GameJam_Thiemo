using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
  
    private void Collect()
    {
       
            if (gameObject.tag == "oil")
            {
                CharacterController.Instance.addOil(30);
            }
            if (gameObject.tag == "Key")
            {
                Inventar.Singleton.activateKey();
            }
            if (gameObject.tag == "Letter")
            {
                TexteundDialoge _text = GetComponent<TexteundDialoge>();
                _text.Activate();
            }

            Destroy(this.gameObject);
        
    }
}
