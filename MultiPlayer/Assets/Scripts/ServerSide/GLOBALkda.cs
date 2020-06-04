using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GLOBALkda : MonoBehaviour
{
    public Text killText;
    public static int killScore = 0;
    public Text deathText;
    public static int deathScore = 0;
    public Text assistText;
    public static int assistScore = 0;

    private void Update()
    {
        killText.text = killScore.ToString();
        deathText.text = deathScore.ToString();
        assistText.text = assistScore.ToString();
    }
}
