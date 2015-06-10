using UnityEngine;
using System.Collections;

public class LivesManager : MonoBehaviour {
    public static int lives = 3;
    //public Sprite kiwi;
    //public Sprite skull;
    public AudioClip GameOver;
	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () {
        //SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if(lives <= 0)
        {
            //sr.sprite = skull;
            Application.LoadLevel("gameover");
        }
	
	}
}
