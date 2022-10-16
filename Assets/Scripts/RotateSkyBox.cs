using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkyBox : MonoBehaviour
{
  
    void FixedUpdate()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1.1f);
    }
}
