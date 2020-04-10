using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPistol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
