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
    private Transform[] _Positions;

    public bool _up = false;

    public void Awake()
    {
        _Positions = Positions.GetComponentsInChildren<Transform>();

    }
  
    private void FixedUpdate()
    {
        if (_up)
        {
            Activate();
        }
        
    }

    public void setText(string ptext)
    {
        _text = ptext;
    }

    public void ChangeText(string pText)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            setText(pText);
        }
    }

    public void UpAnimation()
    {
        setVariable();
        Sprechblase.transform.DOMove(_Positions[1].position, speed).OnComplete(stopTime).SetEase(Ease.OutCirc);
     
    }

    public void DownAnimation()
    {

        Time.timeScale = 1f;
        
        Sprechblase.transform.DOMove(_Positions[0].position, speed).OnComplete(setVariable).SetEase(Ease.OutCirc);
       
        

    }

    public void stopTime() 
    { 
        Time.timeScale = 0f; 
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
        if (!_up)
        {
            textTMP.text = _text;
            _up = true;
        }
        else
        {
            textTMP.text = " ";
            _up = false;
        }
    }
    public IEnumerator Wait()
    {

        yield return new WaitForSeconds(5);

    }
}
