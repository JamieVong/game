using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScoreControl : MonoBehaviour
{
    AudioManager audioManager;
    public GoodEnd goodEnd;
    public TMP_Text scoreText;
    public TMP_Text fishCount;

    private int score, fishcount;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioManager.PlaySFX(audioManager.background);
    }
    void Update()
    {
        
        scoreText.text = score.ToString();
        fishCount.text = fishcount.ToString();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Fish")
        {
            Destroy(target.gameObject);
            audioManager.PlaySFX(audioManager.fish);
            fishcount++;
            if(fishcount == 5)
            {

                SceneManager.LoadScene("BadEnd");
            }

        }
    }
     void OnTriggerExit2D(Collider2D target)
    {
        if(target.tag == "Plastics")
        {
            Destroy(target.gameObject);
            audioManager.PlaySFX(audioManager.plastic);
            score++; 
            if(score == 20)
            {
                SceneManager.LoadScene("GoodEnd");
            }
        }
    }

   // IEnumerator WaitTilRestart()
    //{
//        yield return new WaitForSeconds(1.5f);
     //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}
}
