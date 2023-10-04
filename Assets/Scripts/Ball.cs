using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class Ball : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        Xposition += Xspeed * Time.deltaTime;
        Yposition += Yspeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))

        {
            Yspeed = Yspeed * -1;
        }

        if (collision.gameObject.CompareTag("VerticalWall"))
        {
            Xposition = 0;
            Yposition = 0;
            Yspeed = 0;
            Xspeed = 0;
            
            Yspeed = 5f;
            Xspeed = 5f;
        }



        if (collision.gameObject.CompareTag("VerticalWall2"))
        {
            Xposition = 0;
            Yposition = 0;
            Yspeed = 0;
            Xspeed = 0;
            Yspeed = 5f;
            Xspeed = 5f;
        }

        if (collision.gameObject.CompareTag("Paddle"))
        {
            Xspeed = Xspeed * -1;
        }
    }

}