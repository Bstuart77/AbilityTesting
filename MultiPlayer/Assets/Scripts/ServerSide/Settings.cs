using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

   [HideInInspector] public static float sens = 500f;
    public AudioSource music;
    public AudioSource soundEffects;
    public GameObject pauseMenu;
    public GameObject audioUI;
    public GameObject sensUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
