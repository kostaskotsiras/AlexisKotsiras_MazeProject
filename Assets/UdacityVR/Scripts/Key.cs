using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    //Create a reference to the CoinPoofPrefab
    public GameObject key;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject player;

    private bool checker = false;
    private bool playerHasKey = false;

    public void playClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    public void OnKeyClicked()
    {
        playClip();
        checker = true;
        if (checker == true)
        {
            Destroy(this.gameObject);
            playerHasKey = true;
        }
    }
}