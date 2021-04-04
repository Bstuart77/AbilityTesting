using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScoreboard : MonoBehaviour
{

    public GameObject scoreboard;
    public bool isShowing = false;

    // Start is called before the first frame update
    void Start()
    {
         scoreboard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isShowing)
            {
                scoreboard.SetActive(false);
                isShowing = false;
            }
            else
            {
                scoreboard.SetActive(true);
                isShowing = true;
            }
        }
    }
}
