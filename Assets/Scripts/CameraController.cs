using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public float smoSpd;
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 posDes = player.transform.position + offset;
        Vector3 smoPos = Vector3.Lerp(transform.position, posDes, smoSpd);
        transform.position = smoPos;
        
    }
}
