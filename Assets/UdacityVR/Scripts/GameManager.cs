using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject key;
    public GameObject door;
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (key == false){
            player.tag = "PlayerWithKey";
        }else{
            player.tag = "Player";
        }
		
	}
}
