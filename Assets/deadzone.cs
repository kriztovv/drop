using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class deadzone : MonoBehaviour
{
    public float deadZone;
    public bool gameRunning;
    void Start()
    {
        gameRunning = true;

    }
    void Update()
    {
        if (transform.position.x < -deadZone || transform.position.x > deadZone)
        {
            gameRunning = false;
        }
    }
}