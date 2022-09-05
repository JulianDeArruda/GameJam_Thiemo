using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public static CharacterController Instance;

    [SerializeField] private float speed = 5;
    [SerializeField] private GameObject eElement;
    [SerializeField] private GameObject qElement;
    [SerializeField] private LayerMask interactiveLayer;

    private Rigidbody2D body;
    private CapsuleCollider2D capsuleCollider;
    //private Animator anim;
    private bool interactiveToolInRange;
    private GameObject toolInRange;

    private void Awake()
    {
        Instance = this;
        //anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        interactiveToolInRange = false;
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

        #region basic interaction

        if (Input.GetKeyDown(KeyCode.E))
            interaction();
        if (Input.GetKeyUp(KeyCode.E))
            eLetGo();
        if (Input.GetKeyDown(KeyCode.Q))
            qPressedDown();
        if (Input.GetKeyUp(KeyCode.Q))
            qLetGo();

        #endregion

        //Animator Parameters
        //anim.SetBool("walking",horizontalInput != 0);

    }

    private void interaction()
    {
        eElement.SetActive(true);

        if (interactiveToolInRange)
        {

        }
    }

    private void eLetGo()
    {
        eElement.SetActive(false);
    }

    private void qPressedDown()
    {
        qElement.SetActive(true);
    }

    private void qLetGo()
    {
        qElement.SetActive(false);
    }

    public void setInteranciveToolInRange(bool isToolInRange, GameObject tool)
    {
        interactiveToolInRange = isToolInRange;
        if (isToolInRange == true)
        {
            toolInRange = tool;
        }
        else
        {
            toolInRange = null;
        }
    }


}
