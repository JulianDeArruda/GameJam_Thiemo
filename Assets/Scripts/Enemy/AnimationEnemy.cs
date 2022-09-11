using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnemy : MonoBehaviour
{
    Animator _animator;
    float movev;
    float startv;
    float moveh;
    float starth;
    void Awake()
    {
        _animator = GetComponent<Animator>();
        starth = transform.position.x;
        startv = transform.position.y;
    }


    public void distance()
    {
        movev = startv - transform.position.y; 
        startv = transform.position.y;
        moveh = starth - transform.position.x;
        starth = transform.position.x;
    }
    // Update is called once per frame
    void Update()
    {
        distance();
        if(movev != 0 || moveh != 0)
        {
            _animator.SetBool("Walk", true);
        } else
        {
            _animator.SetBool("Walk", false);
        }
    }
}
