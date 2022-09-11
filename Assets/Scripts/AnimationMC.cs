using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMC : MonoBehaviour
{
    Animator _animator;
    float movev;
    float moveh;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        movev = Input.GetAxis("Vertical");
        moveh = Input.GetAxis("Horizontal");
    }
    // Start is called before the first frame update
    private void Update()
    {
        movev = Input.GetAxis("Vertical");
        moveh = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Q))
        {
            _animator.SetBool("Interaction", true);
            StartCoroutine("wait");
        }
        

        if(moveh != 0 || movev != 0)
        {
            _animator.SetBool("Walking", true);
        }
        else
        {
            _animator.SetBool("Walking", false);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        _animator.SetBool("Interaction", false);
    }

}
