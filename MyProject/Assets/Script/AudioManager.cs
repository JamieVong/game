using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   [Header("----- Audio Source ----")]
   [SerializeField] AudioSource musicSource;
   [SerializeField] AudioSource SFXSource;

   [Header("----- Audio Clip ----")]
   public AudioClip background;
   public AudioClip intro;
   public AudioClip goodend;
   public AudioClip badend;
   public AudioClip fish;
   public AudioClip plastic;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
