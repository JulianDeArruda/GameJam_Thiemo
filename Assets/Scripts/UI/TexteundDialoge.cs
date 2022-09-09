using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class TexteundDialoge : MonoBehaviour
{
    [SerializeField] public GameObject Sprechblase;
    [SerializeField] public string _text;
    [SerializeField] public TMP_Text textTMP;
    [SerializeField] public GameObject Positions;
    [SerializeField] public float speed;
    public Transform[] _Positions;

    public bool _up = false;

    public void Awake()
    {
        _Positions = Positions.GetComponentsInChildren<Transform>();
    }

    public void setText(string ptext)
    {
        _text = ptext;
    }

    public void UpAnimation()
    {
        setVariable();
        Sprechblase.transform.DOMove(_Positions[0].position, speed).SetEase(Ease.OutBounce);
        _up = true; 
        Time.timeScale = 0f;
    }

    public void DownAnimation()
    {
        
        Sprechblase.transform.DOMove(_Positions[1].position, speed).OnComplete(setVariable).SetEase(Ease.InCirc);
        _up = false;
        Time.timeScale = 1f;
    }

    public void Activate()
    {
        if (_up)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DownAnimation();
                
            }
        }
        else
        {
            UpAnimation();
           
        }
    }

    public virtual void setVariable()
    {
        if (_up)
        {
            textTMP.text = _text;
        }
        else
        {
            textTMP.text = "";
        }
    }
}
