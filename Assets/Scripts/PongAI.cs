using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongAI : MonoBehaviour
{
    public float moveSpeed = 3f; // Rename to moveSpeed for clarity
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the difference between the paddle's position and the ball's position
        float verticalDifference = ball.transform.position.y - transform.position.y;

        // Limit the verticalDifference to a reasonable range to avoid excessive movement
        verticalDifference = Mathf.Clamp(verticalDifference, -1f, 1f);

        // Calculate the new yPosition of the paddle
        float newYPosition = transform.position.y + verticalDifference * moveSpeed * Time.deltaTime;

        // Limit the newYPosition to stay within the game boundaries
        newYPosition = Mathf.Clamp(newYPosition, -3.9f, 3.9f);

        // Update the paddle's position
        transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveSpeed++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && moveSpeed > 0) // Check if moveSpeed is greater than 0
        {
            moveSpeed--;
        }

    }
}
