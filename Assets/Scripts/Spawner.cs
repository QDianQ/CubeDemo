using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Spawner : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject cube;
    private bool isStart;

    public static float distance;
    public static float speed;
    public static float timeRespawn;
    public static bool isPhysics;

    public GameObject InputFieldDistanse;
    public GameObject InputFieldSpeed;
    public GameObject InputFieldTime;

    public Toggle ToggleEnablePhysics;


    void Awake()
    {
        distance = float.Parse(InputFieldDistanse.GetComponent<TMP_InputField>().text);
        speed = float.Parse(InputFieldSpeed.GetComponent<TMP_InputField>().text);
        timeRespawn = float.Parse(InputFieldTime.GetComponent<TMP_InputField>().text);

        isStart = false;

        isPhysics = ToggleEnablePhysics.isOn;

    }

    public void StartSpawn()
    {
        isStart = true;
        StartCoroutine(SpawnCube());        
    }
    IEnumerator SpawnCube()
    {
        
        Instantiate(cube, spawnPosition.position, Quaternion.identity);
        yield return new WaitForSeconds(timeRespawn);
        if (isStart) StartSpawn();
    }
    void StopSpawn()
    {
        isStart = false;
    }
    public void GetTimeRespawn(string s)
    {
        if (s != ""){
            timeRespawn = float.Parse(s);
        }
        else
        {
            timeRespawn = 0.25f;
        }
        
    }
    public void GetSpeed(string s)
    {
        if (s != "")
        {
            speed = float.Parse(s);

        }
        else
        {
            speed = 0f;
        }
    }
    public void GetDistance(string s)
    {
        if (s != "")
        {
            distance = float.Parse(s);

        }
        else
        {
            distance = 0f;
        }
    }
    public void getPhysics(bool s)
    {
        isPhysics = s;
    }
}
