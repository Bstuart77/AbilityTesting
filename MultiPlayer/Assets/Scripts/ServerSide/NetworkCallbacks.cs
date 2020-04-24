using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NetworkCallbacks : Bolt.GlobalEventListener
{
    [BoltGlobalBehaviour]
    public override void SceneLoadLocalDone(string scene)
    {
       var spawnPosition = new Vector3(Random.Range(39, 122), 38f, Random.Range(34, -45));
       BoltNetwork.Instantiate(BoltPrefabs.Cube,spawnPosition,Quaternion.identity);
    }
}
