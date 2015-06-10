using UnityEngine;
using System.Collections;

public class PipesScript : MonoBehaviour {
    public GameObject ball;
    public Transform[] spawnPoints;
    //Since blocker gate time + release time = 0.5 and 1.5 then 1.5+0.5 = 2.0
    public float spawnTime;
    public int ballscreated;
	// Use this for initialization
	void Start () 
    {
        spawnTime = 2.0f;
        Invoke("Spawn", spawnTime);
        ballscreated = 0;
        StartCoroutine(timerToSpawn());
	}

    IEnumerator timerToSpawn() 
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnTime);
            Invoke("Spawn", spawnTime);
        }
    }

    void Spawn()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(ball, spawnPoints[index].position, spawnPoints[index].rotation);
        ballscreated++;
        if (ballscreated >= 15)
        {
            spawnTime = 1.8f;
        }
        if (ballscreated >= 30)
        {
            spawnTime = 1.6f;
        }
        if(ballscreated >= 50)
        {
            spawnTime = 1.4f;
        }

    }
	
	// Update is called once per frame
	void Update () 
    {
	
	}

}

