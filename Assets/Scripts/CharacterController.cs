using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    private Rigidbody2D body;
    private BoxCollider2D boxCollider;
    //private Animator anim;

    private void Awake()
    {
        //anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        body.velocity = new Vector2(horizontalInput * speed, verticalInput * speed) ;

        #region Flip Character Model
        //Flip Player
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1,1,1);
        #endregion

        //Animator Parameters
        //anim.SetBool("walking",horizontalInput != 0);

    }
}
