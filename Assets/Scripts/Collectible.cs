using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.tag);
        if (collider.gameObject.tag == "Player")
        {
            string tag = collider.gameObject.tag;
            if (gameObject.tag == "oil")
            {
                CharacterController.Instance.addOil(30);
            }

            Destroy(this.gameObject);
        }
    }
}
