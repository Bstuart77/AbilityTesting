using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPistol : Bolt.GlobalEventListener
{
    public GameObject pistol;
    [BoltGlobalBehaviour]
    public override void SceneLoadLocalDone(string scene)
    {
        var spawnPosition = new Vector3(0, .58f, .075f);
        BoltNetwork.Instantiate(pistol, spawnPosition, Quaternion.identity);
    }
}
