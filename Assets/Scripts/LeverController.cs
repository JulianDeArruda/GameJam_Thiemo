using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    public bool isOn;
    [SerializeField] public Sprite lever_on;
    [SerializeField] public Sprite lever_off;

    private void Update()
    {
        updateSprite();
    }

    public void TriggerLever()
    {
        if (!isOn)
            isOn = true;
        else
            isOn = false;        
    }

    private void updateSprite()
    {
        if (isOn)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = lever_on;
        else
            this.gameObject.GetComponent<SpriteRenderer>().sprite = lever_off;
    }
}
