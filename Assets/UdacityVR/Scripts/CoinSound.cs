using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;
    private bool checker = false;

    public void playClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        checker = true;
    }
}
