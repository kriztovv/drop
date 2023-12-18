using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class spawner : MonoBehaviour
{
    public GameObject box;
    public bool GameRunning;
    public score myScript;

    void Start()
    {
        GameRunning = true;
    }


    void Update()
    {

        if (GameRunning)
        {
            myScript = GameObject.FindWithTag("Logic")?.GetComponent<score>();
            GameRunning = myScript.ResultGameRunning;

            if (Input.GetMouseButtonDown(0))
            { 
                Instantiate(box, transform.position, Quaternion.identity);
        }

        }

    }


}
