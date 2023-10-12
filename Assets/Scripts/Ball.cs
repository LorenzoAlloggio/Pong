using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Ball : MonoBehaviour
{
    public AudioClip BallHitSound;
    private AudioSource audioSource;
    public TMP_Text Scoreboard;
    private int Paddle_1_Score = 0;
    private int Paddle_2_Score = 0;
    private float Xposition = 0f;
    private float Yposition = 0f;
    public float Xspeed;
    public float Yspeed;

    private Vector3 initialPosition; // Store the initial position of the ball.
    private float initialXSpeed;
    private float initialYSpeed;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = new Vector3(Xposition, Yposition, 0);
        initialXSpeed = Xspeed;
        initialYSpeed = Yspeed;
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = BallHitSound;
    }

    // Update is called once per frame
    void Update()
    {
        Scoreboard.text = Paddle_1_Score.ToString() + " - " + Paddle_2_Score.ToString();
        Xposition += Xspeed * Time.deltaTime;
        Yposition += Yspeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            Yspeed = -Yspeed;
            audioSource.Play();
        }

        if (collision.gameObject.CompareTag("VerticalWall"))
        {
            Paddle_2_Score++;
            ResetBall();
            audioSource.Play();
        }

        if (collision.gameObject.CompareTag("VerticalWall2"))
        {
            Paddle_1_Score++;
            ResetBall();
            audioSource.Play();
        }

        Scoreboard.text = Paddle_1_Score.ToString() + " - " + Paddle_2_Score.ToString();

        if (Paddle_1_Score >= 5)
        {
            SceneManager.LoadScene(2);
        }

        if (Paddle_2_Score >= 5)
        {
            SceneManager.LoadScene(3);
        }

        if (collision.gameObject.CompareTag("Paddle"))
        {
            Xspeed = -Xspeed * 1.1f;
            audioSource.Play();
        }
    }

    // Function to reset the ball to its initial state.
    private void ResetBall()
    {
        Xposition = initialPosition.x;
        Yposition = initialPosition.y;
        Xspeed = initialXSpeed;
        Yspeed = initialYSpeed;
    }
}
