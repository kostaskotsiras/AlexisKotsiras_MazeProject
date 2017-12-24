using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coin;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject coinPoof;
    private bool checker = false;
    private bool soundChecker = false;

    public void playClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    public void OnCoinClicked()
    {
        playClip();
        Destroy(this.gameObject);

    }
}

