using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : Bolt.EntityBehaviour<ICustomCubeState>
{
    public static int killAmt = 0;
    public static int deathAmt = 0;
    public void changeScore()
    {
        if (entity.IsOwner && Health.localhealth <=0)
        {

        }
    }
}
