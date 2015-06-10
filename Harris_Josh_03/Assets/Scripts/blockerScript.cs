using UnityEngine;
using System.Collections;

public class blockerScript : MonoBehaviour {
    private bool ballIsActive;
	// Use this for initialization
    public AudioClip ballRelease;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            //collider2D.enabled = true;
            ballIsActive = false;
            StartCoroutine(timerToStart());
        }
    }

    IEnumerator timerToStart()
    {
        //time left to release the ball
        yield return new WaitForSeconds(1.5f);
        this.GetComponent<Collider2D>().enabled = false;
        ballIsActive = true;
        if (this.ballIsActive == true)
        {
            GetComponent<AudioSource>().PlayOneShot(ballRelease);
            //time left to turn the block gate back on
            yield return new WaitForSeconds(0.500f);
            this.GetComponent<Collider2D>().enabled = true;
        }
    }
}
