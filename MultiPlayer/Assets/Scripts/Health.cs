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
        
        if (localhealth <= 0)
        {
            BoltNetwork.Destroy(gameObject);
        }
    }
   

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Bullet(Clone)")
        {
            localhealth -= 1;
            print("HIT");

            BoltNetwork.Destroy(collision.gameObject);
            
            if (localhealth <= 0)
            {
                BoltNetwork.Destroy(gameObject);    
                print("KILLED");
            }
        }
    }
}
