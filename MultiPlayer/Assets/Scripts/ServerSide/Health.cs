using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : Bolt.EntityBehaviour<ICustomCubeState>
{
    public static int localhealth;
    private Rigidbody rb;
    public PistolShooting shootingScript;
    public Text healthScore;
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
    //DONT TOUCH, FIX GLOBAL HEALTH TO CLIENT
    private void HealthCallBack()
    {
        localhealth = state.Health;

        if (localhealth <= 0)
        {
            Score.deathAmt++;
            var spawnPosition = new Vector3(Random.Range(39, 122), 38f, Random.Range(34, -45));
            transform.position = spawnPosition;
            state.Health = 5;
            localhealth = 5;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Bullet(Clone)")
        {
            rb.velocity = new Vector3(0, 0, 0);

            localhealth--;
            state.Health--;

            BoltNetwork.Destroy(collision.gameObject);

            if (localhealth <= 0 && !entity.IsOwner)
            {
                Score.killAmt++;
                state.Health = 5;
                localhealth = 5;
            }
        }

    }
    private void Update()
    {
        healthScore.text = localhealth.ToString();
    }
}
