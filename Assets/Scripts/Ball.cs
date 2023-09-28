using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Xposition, Yposition, 0);

    }
    
    // Update is called once per frame
    void Update()
    {
        Xposition = Xposition + 0.01f;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }
}
