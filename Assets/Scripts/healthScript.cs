using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    public Renderer shieldVisuals;

    public Material[] shieldStates;

    public ValuesObject gameValues;
    public GameObject buttons;
    public GameObject loseText;

    private int currentState = 0;

    private void Start()
    {
        loseText.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState++;
        if (currentState < shieldStates.Length)
            shieldVisuals.material = shieldStates[currentState];
        else
        {
            Time.timeScale = 0;
            gameValues.paused = true;
            buttons.SetActive(true);
            loseText.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
