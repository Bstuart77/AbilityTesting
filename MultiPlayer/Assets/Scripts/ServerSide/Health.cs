using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : Bolt.EntityBehaviour<ICustomCubeState>
{
    public static int localhealth;
    private Rigidbody rb;
    public PistolShooting shootingScript;
    public Text killScore;
    public Text deathScore;
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
        localhealth = state.Health;
    }

    private void Update()
    {
        killScore.text = Score.killAmt.ToString();
        deathScore.text = Score.deathAmt.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Bullet(Clone)")
        {
            rb.velocity = new Vector3(0, 0, 0);

            BoltNetwork.Destroy(collision.gameObject);
            localhealth--;

            if(localhealth <= 0 && entity.IsOwner)
            {
                var spawnPosition = new Vector3(Random.Range(39, 122), 38f, Random.Range(34, -45));
                transform.position = spawnPosition;
                localhealth = 5;
                Score.deathAmt++;
            }
        }
    }
}
