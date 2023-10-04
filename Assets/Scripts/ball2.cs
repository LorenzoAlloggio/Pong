using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball2 : MonoBehaviour
{
    public float speed = 5f;

    private Vector2 direction;

    void Start()
    {
        // Start the ball moving in a random direction
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    void Update()
    {
        // Move the ball based on the direction and speed
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
