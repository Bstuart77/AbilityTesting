using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : Bolt.GlobalEventListener
{
    public override void OnEvent(ScoreEvent evnt)
    {
        print(evnt.Message);
    }
}
