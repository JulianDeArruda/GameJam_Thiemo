using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTypB : EnemyController
{

    public override void search()
    {
        if (shootRaycastAtPlayer(barrierLayer).collider != null)
        {
            //Debug.Log("Found Barrier");
        }
        else if (shootRaycastAtPlayer(lightLayer).collider != null || shootRaycastAtPlayer(playerLayer).collider != null)
        {
            //Debug.Log(" Game Over ");
            //Spiel vorbei
            SceneManager.LoadScene(0);
        }
    }
}
