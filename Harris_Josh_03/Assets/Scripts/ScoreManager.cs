using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// Code help used from: http://unity3d.com/learn/tutorials/projects/survival-shooter/scoring-points
public class ScoreManager : MonoBehaviour {
	// Use this for initialization

    Text scoreText;
    public static int score;

	void Start () 
    {
	    score = 0;
	}

    void Awake()
    {
        scoreText = GetComponent<Text>();
        score = 0;
    }
	
	// Update is called once per frame
    void Update()
    {
        string myScore = score.ToString();
        scoreText.text = myScore;
    }

}
