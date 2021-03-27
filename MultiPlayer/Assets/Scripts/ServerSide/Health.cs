using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : Bolt.EntityBehaviour<ICustomCubeState>
{
    public static int localhealth;
    private Rigidbody rb;
    public PistolShooting shootingScript;
    public shootAR shootingScript2;

    public override void Attached()
    {
        state.Health = localhealth;
        state.AddCallback("Health", HealthCallBack);
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        localhealth = 5;
    }

    private void HealthCallBack()
    {
        state.Health =localhealth;

        if (localhealth <= 0)
        {
            Score.deathAmt++;
            var spawnPosition = new Vector3(Random.Range(39, 122), 38f, Random.Range(34, -45));
            transform.position = spawnPosition;
            localhealth = 5;
            state.Health = 5;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //DO NOT TOUCH!@!!!!!!!!!!!!!!!!!!
        //TRY TO FIX KILLS - USE GAME SHIT FOLDER
        //create bullet script for despawnign bullets when colliding with players
        if (collision.transform.name == "Bullet(Clone)")
        {
            if (entity.IsOwner) { 
                rb.velocity = new Vector3(0, 0, 0);
                localhealth--;
                state.Health--;
            }
            BoltNetwork.Destroy(collision.gameObject);
        }
        
            if (state.Health <= 0 && !entity.IsOwner)
            {
                Score.killAmt++;
                localhealth = 5;
            }
    }
}
