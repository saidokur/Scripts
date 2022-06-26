using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerCamera : MonoBehaviour
{
    public Transform Player, Camera;
    public float trackSpeed;
    public Vector3 distance;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera.position = Vector3.Lerp(Camera.position, Player.position-distance,trackSpeed);
    }
}
