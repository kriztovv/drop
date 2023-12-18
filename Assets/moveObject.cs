using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    public float speed = 5.0f;  
    public float edgeSlowingDistance = 1.0f;  

    private Vector3 initialPosition;
    private float targetXPosition;

    void Start()
    {
        initialPosition = transform.position;
        targetXPosition = initialPosition.x;
    }

    void Update()
    {

        targetXPosition = initialPosition.x + Mathf.PingPong(Time.time * speed, edgeSlowingDistance * 2) - edgeSlowingDistance;
        Vector3 currentPosition = transform.position;
        Vector3 targetPosition = new Vector3(targetXPosition, currentPosition.y, currentPosition.z);
        transform.position = Vector3.Lerp(currentPosition, targetPosition, Time.deltaTime);
    }
}
