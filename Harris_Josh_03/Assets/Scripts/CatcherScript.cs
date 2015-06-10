using UnityEngine;
using System.Collections;

public class CatcherScript : MonoBehaviour {

    public float velocity;
    public float leftBoundary;
    public float rightBoundary;

    private Vector3 position;

	// Use this for initialization
	void Start () {
        position = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * velocity;

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(position.x < -leftBoundary)
        {
            position.x = -leftBoundary;
        }

        if(position.x > rightBoundary)
        {
            position.x = rightBoundary;
        }

        transform.position = position;

	}
}
