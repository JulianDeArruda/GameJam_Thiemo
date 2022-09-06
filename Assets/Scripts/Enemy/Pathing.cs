using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pathing : MonoBehaviour
{
    private Transform[] _paths;
    [SerializeField] float movementSpeed;

    Vector3 _Point;
    private int pathpoints = 0;
    [SerializeField] GameObject _parent;
    private void Awake()
    {
       
        _paths = _parent.transform.GetComponentsInChildren<Transform>();
        doMove();
        
    }

   
    private void doMove()
    {
        NewPoint();
        transform.DOMove(_Point, movementSpeed).OnComplete(doMove).SetEase(Ease.InSine);
    }

    private void NewPoint()
    {
        
        _Point = _paths[pathpoints].position;
        transform.right = _Point - transform.position;
        if(pathpoints >= _paths.Length-1)
        {
            pathpoints = 0;
        }
        else
        {
            pathpoints++;
        }
        
    }
    

}
