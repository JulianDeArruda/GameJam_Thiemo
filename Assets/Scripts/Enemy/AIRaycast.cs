using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRaycast : MonoBehaviour
{
    [SerializeField] int range;
    
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), range,6);
        
        if (hit.collider != null)
        {
            
         if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("GameOver");
            }

        if (hit.collider.CompareTag("Light"))
        {
            Debug.Log("Light");
        }
        }
      

    }


}
