using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveFinish : MonoBehaviour
{

    public static float distance;

    private void Start()
    {
        distance = Spawner.distance -4f;
        
    }

    private void FixedUpdate()
    {
        moveFinishLine();
    }

    public void SetFinish(string s)
    {
        if (s != "")
        {
            distance = float.Parse(s) - 4f;

        }
        else
        {
            distance = -4f;
        }
        
    }
    private void moveFinishLine()
    {
        transform.position= Vector3.Lerp(transform.position,
                                          new Vector3(0.0f, 0.01f, distance),
                                          Time.deltaTime * 5f);
    }
}
