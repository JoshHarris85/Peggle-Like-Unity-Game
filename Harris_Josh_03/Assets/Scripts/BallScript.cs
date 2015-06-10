using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
    public AudioClip droppedBall;
    public AudioClip pegBounce;
    public AudioClip caughtBall;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -4.418)
        {
            GetComponent<AudioSource>().PlayOneShot(droppedBall);
            Destroy(this.gameObject);
            LivesManager.lives -= 1;
        }
    }
    //Audio for catcher and lost ball will not work in here and above. Why?
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Catcher")
        {
            GetComponent<AudioSource>().PlayOneShot(caughtBall);
            Destroy(this.gameObject);
            ScoreManager.score += 1;
            
        }
        if(collision.gameObject.tag == "pegs")
        {
            GetComponent<AudioSource>().PlayOneShot(pegBounce);
        }
    }
}