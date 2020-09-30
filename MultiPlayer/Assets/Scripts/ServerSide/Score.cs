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

    public GameObject scoreboardPrefab;
    public float UISpacing;
    private List<GameObject> updateUI = new List<GameObject>();

    private void Update()
    {
        BoltNetwork.Instantiate(scoreboardPrefab);
        scoreboardPrefab.transform.localPosition = new Vector3(0, UISpacing * updateUI.Count, 0);
        scoreboardPrefab.gameObject.SetActive(true);

        killScore.text = killAmt.ToString();
        deathScore.text = deathAmt.ToString();
        healthScore.text = Health.localhealth.ToString();
    }
}
