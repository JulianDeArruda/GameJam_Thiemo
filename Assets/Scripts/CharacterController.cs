using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public static CharacterController Instance;

    [SerializeField] private float speed = 5;
    [SerializeField] private LayerMask interactiveLayer;
    [SerializeField] private GameObject exclamationmark;

    private Rigidbody2D body;

    private void Awake()
    {
        Instance = this;
        //anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        #region general movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        body.velocity = new Vector2(horizontalInput * speed, verticalInput * speed) ;
        #endregion

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

    public void notifyPlayer()
    {
        exclamationmark.SetActive(true);
    }

    public void deNotifyPlayer()
    {
        exclamationmark.SetActive(false);
    }


}
