using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speedB = 50.0f;
    public Rigidbody2D Ball;
    public float force;
    private uiManager SCORE;
    private AudioSource tickSource;
  //  private uiManager LIFE;
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
        SCORE = GameObject.Find("Canvas").GetComponent<uiManager>();
        Addforce();
    }
    public void Addforce()
    {
        Ball.AddForce(new Vector2(force, force) * Time.deltaTime * speedB);
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bricks")
        {
            SCORE.ScoreCounter();
            tickSource.Play();
            Destroy(other.gameObject);
        }
        if (other.tag == "LifeDecrease")
        {
           SCORE.LifeCounter();
        }
    }

}
