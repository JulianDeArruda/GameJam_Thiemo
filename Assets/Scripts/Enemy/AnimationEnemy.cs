using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnemy : MonoBehaviour
{

    //das Script funktioniert net
    [SerializeField]SpriteRenderer _sprite;
    
   
    
    

    public void adjustGraphics(float inX)
    {
        if (transform.position.x < inX)
        {
            //Debug.Log("Rechts");
            _sprite.flipX = true;
        }
        else
        {
            //Debug.Log("Links");
           
            _sprite.flipX = false;
        }
    }

   
}
