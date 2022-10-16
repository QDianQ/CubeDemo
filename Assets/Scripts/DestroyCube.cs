using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{

    private float distance;

    private void Start()
    {
        distance = Spawner.distance;
    }
    private void FixedUpdate()
    {
        FinishPosition();
    }
    private void FinishPosition()
    {
        if (gameObject.transform.position.z > MoveFinish.distance)
        {
            Destroy(gameObject);
        }
    }
}
