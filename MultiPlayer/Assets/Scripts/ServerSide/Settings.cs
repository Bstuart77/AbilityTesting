using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Settings : MonoBehaviour
{

   private float sens = 1f;
    public AudioSource music;
    public Slider musicSlider;
    public AudioSource soundEffects;
    public Slider soundEffectsSlider;

    public GameObject pauseMenu;
    public GameObject audioUI;
    public GameObject sensUI;
    public Slider sensSlider;


    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        music.volume = PlayerPrefs.GetFloat("music");
        soundEffects.volume = PlayerPrefs.GetFloat("soundEffects");
        sensSlider.value = PlayerPrefs.GetFloat("sens");
        pauseMenu.SetActive(false);
    }

    public void MusicVolume(float vol)
    {
        music.volume = vol;
        PlayerPrefs.SetFloat("volume", music.volume);
        PlayerPrefs.Save();
    }

    public void SoundEffects(float soundEffectsSlider)
    {
        soundEffects.volume = soundEffectsSlider;
        PlayerPrefs.SetFloat("soundEffects", soundEffects.volume);
        PlayerPrefs.Save();
    }

    public void Sens(float sens)
    {
        sensSlider.value = sens;
        PlayerPrefs.SetFloat("sens", sensSlider.value);
        PlayerPrefs.Save();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            { 
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    public void Paused()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
    }

    public void Back()
    {
        pauseMenu.SetActive(true);
        audioUI.SetActive(false);
        sensUI.SetActive(false);
    }

    public void ShowVolumeSlider()
    {
        audioUI.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void ShowSensSlider()
    {
        pauseMenu.SetActive(false);
        sensUI.SetActive(true);
    }

    public void LeaveGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
