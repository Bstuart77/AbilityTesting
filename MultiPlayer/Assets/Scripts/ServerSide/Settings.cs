using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Settings : MonoBehaviour
{
    private float sens;
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
        if(PlayerPrefs.GetFloat("musicVolume") == 0f)
        {
            musicSlider.value = 1f;
        }
        if(PlayerPrefs.GetFloat("sens") == 0f)
        {
            sensSlider.value *= 1000f;
        }

        music.volume = PlayerPrefs.GetFloat("musicVolume");
        musicSlider.value = music.volume;
        sensSlider.value = PlayerPrefs.GetFloat("sens");

        soundEffects.volume = PlayerPrefs.GetFloat("soundEffects");
        pauseMenu.SetActive(false);
    }

    public void MusicVolume(float vol)
    {
        music.volume = vol;
        PlayerPrefs.SetFloat("musicVolume", music.volume);
        PlayerPrefs.Save();
    }

    public void SoundEffects(float soundEffectsSlider)
    {
        soundEffects.volume = soundEffectsSlider;
        PlayerPrefs.SetFloat("soundEffects", soundEffects.volume);
        PlayerPrefs.Save();
    }

    public void Sens(float sensitivity)
    {
        sensSlider.value = sensitivity;
        PlayerPrefs.SetFloat("sens", sensSlider.value * 1000);
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
