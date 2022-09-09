using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] public float detectionRange = 6;
    [SerializeField] public GameObject player;    
    [SerializeField] public LayerMask playerLayer;
    [SerializeField] public LayerMask lightLayer;
    [SerializeField] public LayerMask barrierLayer;


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
           // Debug.Log("Found Light");
        }else if (shootRaycastAtPlayer(playerLayer).collider != null)
        {
            Debug.Log("Found Player");
        }
    }

    public RaycastHit2D shootRaycastAtPlayer(LayerMask layermask)
    {
        return Physics2D.Raycast(this.gameObject.transform.position, player.transform.position, detectionRange,layermask);
    }
}
