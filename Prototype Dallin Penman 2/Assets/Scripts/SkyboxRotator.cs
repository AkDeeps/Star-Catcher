using UnityEngine;
using System.Collections;

public class SkyboxRotator : MonoBehaviour
{

    public float adjustment = 2;

    void Update()


    { RenderSettings.skybox.SetFloat("_Rotation", Time.time * adjustment); }
}