using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Ball : MonoBehaviour

{
    public AudioClip BallHitSound;
    private AudioSource audioSource;
    public TMP_Text Scoreboard;
    private int Paddle_1_Score = 0;
    private int Paddle_2_Score = 0;
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float Xspeed;
    public float Yspeed;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(Xposition, Yposition, 0);
        Xspeed = 5f;
        Yspeed = 5f;
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
            Yspeed = Yspeed * -1;
            audioSource.Play();            
        }

        if (collision.gameObject.CompareTag("VerticalWall"))
        {
            Paddle_2_Score++;
            Xposition = 0;
            Yposition = 0;
            Yspeed = 5f;
            Xspeed = 5f;
            audioSource.Play();
        }



        if (collision.gameObject.CompareTag("VerticalWall2"))
        {
            Paddle_1_Score++;
            Xposition = 0;
            Yposition = 0;
            Yspeed = 0;
            Xspeed = 0;
            Yspeed = 5f;
            Xspeed = -5f;
            audioSource.Play();
        }

        Scoreboard.text = Paddle_1_Score.ToString() + " - " + Paddle_2_Score.ToString();

        if (Paddle_1_Score >= 5)
        {
            SceneManager.LoadScene(4);
        }

        if (Paddle_2_Score >= 5)
        {
            SceneManager.LoadScene(5);
        }

        if (collision.gameObject.CompareTag("Paddle"))
        {
            Xspeed = Xspeed * -1.1f;
            audioSource.Play();
        }


    }


}