using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : Bolt.EntityBehaviour<ICustomCubeState>
{
    public static int killAmt = 0;
    public static int deathAmt = 0;
    public Text killScore;
    public Text deathScore;
    public Text healthScore;


    private void Update()
    {
        killScore.text = killAmt.ToString();
        deathScore.text = deathAmt.ToString();
        healthScore.text = Health.localhealth.ToString();
    }
}
