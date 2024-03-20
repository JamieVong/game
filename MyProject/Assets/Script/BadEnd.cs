using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BadEnd : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioManager.PlaySFX(audioManager.badend);
    }
    public void Replay()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main");
    }
}
