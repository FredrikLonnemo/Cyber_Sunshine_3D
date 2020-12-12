using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSkybox : MonoBehaviour
{
    public Material skybox1;
    public Material skybox2;
    public ValuesObject gameValues;

    public void Start()
    {

        Toggle();
        Toggle();
    }
    public void Toggle()
    {
        if (gameValues.skybox)
            RenderSettings.skybox = skybox2;
        else
            RenderSettings.skybox = skybox1;

        gameValues.skybox = !gameValues.skybox;
        DynamicGI.UpdateEnvironment();
    }
}
