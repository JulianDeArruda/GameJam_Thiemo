using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StroyScript : MonoBehaviour
{
   
   [SerializeField] Camera[] cameras;
    private Sprechblasen sb;
    private TexteundDialoge Info;
    private bool qPressed= true;
   
    public string text = " ";

    // Start is called before the first frame update
    void Awake()
    {

        sb = GetComponent<Sprechblasen>();
        //Lamp on
        cameras[0].enabled = false;
        cameras[1].enabled = true;
    }

    private void Start()
    {
        Beginning();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

        
        if (text == "huh" )
        {
            sb.setText("huh");
            text = "q";

        } 
        if (text == "q")
            {
                sb.setText("Press Q to use lamp.");
                end();

            }
            if (text == "sick")
            {
                sb.setText("... cough cough ... uhh..");
                    text ="help";

            }
            if (text == "help")
            {
                sb.setText("need to find help for bro! what can I do?");
                text = "wasd";

            }
            if (text == "wasd")
            {
                Info.setText("Leave the Room! Use WASD to move around!");

            }

        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            sb.setText("bro...whats wrong? you look sick...");
            sb.UpAnimation();

            text = "sick";
        }
    }
    public void end()
    {
        sb.DownAnimation();
        
        
    }
    public void Beginning()
    {
        cameras[1].GetComponent<Animator>().Play("Shake");
        StartCoroutine(Wait());
        ChangeCamera();
        sb.setText("wtf is happening ? ");
        //Sprechblase
        sb.UpAnimation();
        StartCoroutine(Wait());
        text = "huh";
        

        //PlayShake
        //Courtine

        //What
        //Press Q
        //give lamp unendlich Öl
    }
    
    public void ChangeCamera()
    {
        cameras[0].enabled = true;
        cameras[1].enabled = false;
        
    }


    public IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(5);
        
    }


}
