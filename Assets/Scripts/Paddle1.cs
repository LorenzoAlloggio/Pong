using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        // Use both "Vertical" and "W" and "S" keys for movement
        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1f;
        }

        Vector3 movement = new Vector3(0, verticalInput, 0) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
