using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPistol : MonoBehaviour
{
    public GameObject pistol;

    private void Start()
    {
        StartCoroutine(pistolSpawn());
    }
    IEnumerator pistolSpawn() {

        while (Timer.timeLeft > 0)
        {
            pistol.SetActive(true);
            yield return new WaitForSeconds(5f);
        }
    
    }
}

