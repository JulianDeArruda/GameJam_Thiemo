using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyController : MonoBehaviour
{
    [SerializeField] public float detectionRange = 6;
    [SerializeField] public GameObject player;    
    [SerializeField] public LayerMask playerLayer;
    [SerializeField] public LayerMask lightLayer;
    [SerializeField] public LayerMask barrierLayer;

    private Transform[] _paths;
    [SerializeField] float movementSpeed;

    Vector3 _Point;
    private int pathpoints = 0;
    [SerializeField] GameObject _parent;
    AnimationEnemy animationEnemy;

    private bool playerFound;

    private void Awake()
    {
        playerFound = false;
        _paths = _parent.transform.GetComponentsInChildren<Transform>();
        animationEnemy = GetComponent<AnimationEnemy>();
        doMove();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        search();
    }

    public virtual void search()
    {
        if (shootRaycastAtPlayer(barrierLayer).collider != null){
            //Debug.Log("Found Barrier");
        }else if (shootRaycastAtPlayer(lightLayer).collider != null)
        {
            //Debug.Log("Found Light");
        }else if (shootRaycastAtPlayer(playerLayer).collider != null)
        {
            //Debug.Log("Found Player");
        }
    }

    public RaycastHit2D shootRaycastAtPlayer(LayerMask layermask)
    {
        //return Physics2D.Raycast(this.gameObject.transform.position, player.transform.position, detectionRange,layermask);
        return Physics2D.Raycast(this.gameObject.transform.position, transform.right, detectionRange, layermask);
    }

    private void doMove()
    {
        NewPoint();
        transform.DOMove(_Point, movementSpeed).OnComplete(doMove).SetEase(Ease.InSine);
    }

    private void NewPoint()
    {

        _Point = _paths[pathpoints].position;
        animationEnemy.adjustGraphics(_Point.x);
        transform.right = _Point - transform.position;
        if (pathpoints >= _paths.Length - 1)
        {
            pathpoints = 0;
        }
        else
        {
            pathpoints++;
        }

    }

}
