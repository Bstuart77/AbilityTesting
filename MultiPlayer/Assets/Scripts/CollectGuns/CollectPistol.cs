using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPistol : Bolt.GlobalEventListener
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Cube(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
