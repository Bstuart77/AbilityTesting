using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : Bolt.EntityBehaviour<ICustomCubeState>
{
    public static int score = 1;

    public void changeScore()
    {
        if (entity.IsOwner && score == 5)
        {
            Health.killAmt++;
            score = 0;

            /*var scoreEvent = ScoreEvent.Create();
//            scoreEvent.Message = PlayerPrefs.GetString("username") + " scored " + Health.killAmt;
           scoreEvent.Send();*/
        }
    }
}
