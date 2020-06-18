using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoined : Bolt.EntityBehaviour<ICustomCubeState>
{
    public Camera entityCamera;

    public override void Attached()
    {
        var evnt = PlayerJoinedEvent.Create();
        evnt.Message = "Hello There!";
        evnt.Send();

        PlayerPrefs.SetString("username", Random.Range(0, 999).ToString());
    }

     void Update()
    {
        if (entity.IsOwner && entityCamera.gameObject.activeInHierarchy == false)
        {
            entityCamera.gameObject.SetActive(true);
        }
    }
}
