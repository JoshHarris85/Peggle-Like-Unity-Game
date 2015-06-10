using UnityEngine;
using System.Collections;

public class GameOVerSounds : MonoBehaviour {
    public AudioClip endGame;
	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().PlayOneShot(endGame);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
