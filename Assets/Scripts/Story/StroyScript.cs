using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StroyScript : MonoBehaviour
{
    
   [SerializeField] Camera[] cameras;
   // private Sprechblasen sb;
    private bool beginning= true;
    
    // Start is called before the first frame update
    void Awake()
    {
   //     sb = GetComponent<Sprechblasen>();
        //Lamp on
        cameras[0].enabled = false;
        cameras[1].enabled = true;
    }

    private void Start()
    {
        Beginning();
    }

    // Update is called once per frame
    void Update()
    {
        
        
       // if (sb._up)
       // {
           // sb.Activate();
      //  }
    }

    public void Beginning()
    {
        cameras[1].GetComponent<Animator>().Play("Shake");
        Wait();
        ChangeCamera();
        
        //Sprechblase
       // sb.Activate();
        
        
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
