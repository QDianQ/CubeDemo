using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCube : MonoBehaviour
{
    private Rigidbody rb;

    private float speed;
    private float distance;
    private bool isPhisical;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        
        
    }
    void FixedUpdate()
    {
        speed = 10f * Spawner.speed;
        distance = Spawner.distance;
        isPhisical = Spawner.isPhysics;
        MoveForward();

    }
    void MoveForward()
    {
        if (isPhisical)
            rb.AddForce(0f, 0f, speed);
        else
        {
            transform.position = Vector3.MoveTowards(transform.position,
                                                    new Vector3(0f, 0f, distance + 10),
                                                    Time.deltaTime * speed);
        }
    }

}
    
