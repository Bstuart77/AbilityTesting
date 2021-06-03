using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : Bolt.EntityBehaviour<ICustomCubeState>
{
    public static int killAmt = 0;
    public static int deathAmt = 0;
    public Text healthScore;
    public Text killScore;
    public Text deathScore;
    public Text scoreboardName;

    private void Update()
    {
        killScore.text = killAmt.ToString();
        deathScore.text = deathAmt.ToString();
        scoreboardName.text = PlayerPrefs.GetString("username").ToString();
        healthScore.text = Health.localhealth.ToString();
    }
}
