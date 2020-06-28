using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    public PistolShooting shootingScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            shootingScript.scoreScript.changeScore();
            Destroy(gameObject);
        }
    }
}
