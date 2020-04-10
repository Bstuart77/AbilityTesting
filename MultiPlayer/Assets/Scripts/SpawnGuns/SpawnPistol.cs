using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPistol : MonoBehaviour
{
    public GameObject pistol;

     void Start()
    {
        StartCoroutine(spawnPistol());
    }

    IEnumerator spawnPistol()
    {
        Instantiate(pistol, new Vector3(114, 37, 0), Quaternion.Euler(90,0,0));

        yield return new WaitForSeconds(5f);
    }
}
