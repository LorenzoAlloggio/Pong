using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour
{
    public Text player1ScoreText;
    public Text player2ScoreText;



    private int player1Score = 0;
    private int player2Score = 0;



    void Start()
    {
        UpdateScoreText();
    }



    public void Player1Scored()
    {
        player1Score++;
        UpdateScoreText();
    }



    public void Player2Scored()
    {
        player2Score++;
        UpdateScoreText();
    }



    void UpdateScoreText()
    {
        player1ScoreText.text = "P1: " + player1Score;
        player2ScoreText.text = "P2: " + player2Score;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("VerticalWall2"))
        {
            Player1Scored();
        }
        else if (collision.gameObject.CompareTag("VerticalWall"))
        {
            Player2Scored();
        }
    }
}