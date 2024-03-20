using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{ AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioManager.PlaySFX(audioManager.intro);
    }
    public void SwitchScene()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
