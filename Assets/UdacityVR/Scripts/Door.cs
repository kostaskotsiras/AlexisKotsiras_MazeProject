using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    public bool locked;
    public bool opening;
    public GameObject player;
    public Animator anim;
    public AudioSource audioSource;
    public AudioClip audioClipOpen;
    public AudioClip audioClipLocked;
    public GameObject winUI;

    Collider doorCollider;

    void Start() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        anim.Play("Idle");
        doorCollider = GetComponent<Collider>();
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
        if (player.tag == "Player")
        {
            opening = false;
            anim.Play("TryingToOpen");
            audioSource.clip = audioClipLocked;
            audioSource.Play();
            anim.Play("Idle");
            Debug.Log("The door is locked");
        }
        if (player.tag == "PlayerWithKey"){
            opening = true;
            anim.Play("OpenDoor");
            audioSource.clip = audioClipOpen;
            audioSource.Play();
            doorCollider.enabled = !doorCollider.enabled;
            winUI.SetActive(true);
            Debug.Log("Opening Door");
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
