using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : Bolt.EntityBehaviour<ICustomCubeState>
{
    public int score;

    public void changeScore()
    {
        if (entity.IsOwner)
        {
            score++;

            var scoreEvent = ScoreEvent.Create();
            scoreEvent.Message = PlayerPrefs.GetString("username") + " scored " + score;
            scoreEvent.Send();
        }
    }
}
