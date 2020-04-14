using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPistol : MonoBehaviour
{
    public GameObject pistol;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube(Clone)")
        {
            pistol.SetActive(false);
        }
    }
    private void Update()
    {
        if(gameObject.name == "Cube(Clone)")
        {
            pistol.SetActive(true);
        }
    }
}
