using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    public PistolShooting shootingScript;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            shootingScript.scoreScript.changeScore();
            Score.score++;
            Destroy(gameObject);
        }
    }
    
}
