using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoodEnd : MonoBehaviour
{ 
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioManager.PlaySFX(audioManager.goodend);
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
