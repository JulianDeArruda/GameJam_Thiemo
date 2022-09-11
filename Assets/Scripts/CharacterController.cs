using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public static CharacterController Instance;

    [SerializeField] private float speed = 5;
    [SerializeField] private LayerMask interactiveLayer;
    [SerializeField] private GameObject exclamationmark;
    [SerializeField] GameObject lamp;

    public float maxOil = 120;
    public float oil = 30;
    private bool lightOn;    
    private Rigidbody2D body;
    private Vector2 _move;

    private void Awake()
    {
        Instance = this;
        //anim = GetComponent<Animator>();
        lightOn = false;
        body = GetComponent<Rigidbody2D>();

      FindObjectOfType<UIManager>().Intro(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        #region general movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        _move = new Vector2(horizontalInput, verticalInput) ;
        #endregion

        #region Flip Character Model
        //Flip Player
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1,1,1);
        #endregion

        #region oil management
        if (oil <= 0)
        {
            if (lightOn == true)
            {
                lightOn = false;
                lamp.SetActive(false);
                SoundManager.Instance.playSound(Sounds.LampOff);
                oil = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q) && oil > 0)
        {
            if (lightOn == false)
            {
                lightOn = true;
                SoundManager.Instance.playSound(Sounds.LampOn);
                lamp.SetActive(true);
            }
            else
            {
                lightOn = false;
                SoundManager.Instance.playSound(Sounds.LampOff);
                lamp.SetActive(false);
            }
        }
        if (lightOn)
        {
            oil -= Time.deltaTime;
        }
        #endregion

        if (Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<UIManager>().Intro(false);
        }
        //Animator Parameters
        //anim.SetBool("walking",horizontalInput != 0);

    }

    private void FixedUpdate()
    {
        body.MovePosition(body.position + (_move * speed * Time.deltaTime));
    }

    public void notifyPlayer()
    {
        exclamationmark.SetActive(true);
    }

    public void deNotifyPlayer()
    {
        exclamationmark.SetActive(false);
    }

    public void addOil(float extraOil)
    {
        if ((oil + extraOil) <= maxOil)
            oil += extraOil;
        else
            oil = maxOil;
    }
}
