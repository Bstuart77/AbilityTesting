using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NetworkCallbacks : Bolt.GlobalEventListener
{
    [BoltGlobalBehaviour]
    public override void SceneLoadLocalDone(string scene)
    {
        var spawnPosition = new Vector3(Random.Range(-175, -75), 0, Random.Range(5, 105));
       BoltNetwork.Instantiate(BoltPrefabs.Cube,spawnPosition,Quaternion.identity);
    }
}
