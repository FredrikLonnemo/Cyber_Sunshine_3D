using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ValuesObject : UnityEngine.ScriptableObject
{
#if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
#endif

    public bool paused;

    public int timerMax = 250;
    public int spawnMax = 250;

    public int startDifficulity = 0;
    public float diffMult = 5;
    public int maxDifficulity = 35;

    public float lookSensitivity = 5;
    public bool skybox = false;
    public bool planets = true;
}