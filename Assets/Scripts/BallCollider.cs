using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5.0f; // Adjust the speed as needed

    private Vector2 ballDirection;

    void Start()
    {
        // Initialize the ball's direction (you can change this for the initial direction)
        ballDirection = new Vector2(1, 1).normalized;
        // Start the ball movement
        transform.position = Vector2.zero;
    }

    void Update()
    {
        // Move the ball by directly manipulating its position
        Vector2 newPosition = (Vector2)transform.position + (ballDirection * speed * Time.deltaTime);
        transform.position = newPosition;

        // Check for collisions with walls and change direction accordingly
        CheckForWallCollision();
    }

    void CheckForWallCollision()
    {
        Vector2 ballPosition = transform.position;
        float ballRadius = transform.localScale.x / 17.7f; // Assumes the ball has a uniform scale

        /*if (ballPosition.x + ballRadius > 8.0f || ballPosition.x - ballRadius < -8.0f)
        {
            // Ball hit the left or right wall, reverse the x direction
            ballDirection.x *= -1;
        }
        */
        if (ballPosition.y + ballRadius > 4.8f || ballPosition.y - ballRadius < -4.8f)
        {
            // Ball hit the top or bottom wall, reverse the y direction
            ballDirection.y *= -1;
        }
    }

}
