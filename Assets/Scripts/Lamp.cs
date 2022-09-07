using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    [SerializeField] GameObject lamp;
    private bool LightOn;



    private void Start()
    {
        LightOn = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (LightOn == false)
            {
                LightOn = true;
                lamp.SetActive(true);
            }
            else
            {
                LightOn = false;
                lamp.SetActive(false);
            }
        }
    }
}