using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class move : MonoBehaviour
{
    public float yPos;
    public float up;
    public bool GameRunning;
    void Start()
    {
        yPos = 0;
        new Vector3 (0, 0, 0);
        GameRunning = true;
    }

    private void Update()
    {
        score myScript = GameObject.FindWithTag("Logic")?.GetComponent<score>();
        GameRunning = myScript.ResultGameRunning;
        if(GameRunning )
        {
        if (Input.GetMouseButtonDown(0))
        {
        yPos = yPos + up;
            transform.position = new Vector3(0f, yPos, 0f);
        }
        }

    }



}
