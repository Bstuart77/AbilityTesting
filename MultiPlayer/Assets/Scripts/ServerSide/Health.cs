using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : Bolt.EntityBehaviour<ICustomCubeState>
{
    public int localhealth;

    public override void Attached()
    {
        state.Health = localhealth;
        state.AddCallback("Health", HealthCallBack);
    }

    private void HealthCallBack()
    {
        localhealth = state.Health;
    }
   

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Bullet(Clone)")
        {
            localhealth -= 1;

            BoltNetwork.Destroy(collision.gameObject);
            
            if (localhealth <= 0)
            {
                GLOBALkda.killScore++;
                var spawnPosition = new Vector3(Random.Range(39, 122), 38f, Random.Range(34, -45));
                transform.position = spawnPosition;
                localhealth = 5;
            }
        }
    }
}
