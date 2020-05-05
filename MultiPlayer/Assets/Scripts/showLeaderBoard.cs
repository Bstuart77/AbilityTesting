using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLeaderBoard : MonoBehaviour
{
    private static bool showScoreBoard = false;
    public GameObject scoreBoard;

    private void Start()
    {
        scoreBoard.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)){
            if (showScoreBoard)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        scoreBoard.SetActive(false);
        showScoreBoard = false;
    }

    public void Pause()
    {
        scoreBoard.SetActive(true);
        showScoreBoard = true;
    }
}
