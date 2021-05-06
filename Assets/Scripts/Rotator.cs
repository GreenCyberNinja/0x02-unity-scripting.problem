using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * speed, 0.0f, 0.0f, Space.Self);        
    }
}
