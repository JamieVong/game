using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
    }
}