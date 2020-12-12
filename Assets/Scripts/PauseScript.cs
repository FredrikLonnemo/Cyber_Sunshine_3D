using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public ValuesObject gameValues;
    public GameObject pausePanel;
    public GameObject SharedButtons;

    public GameObject loseText;

    // Start is called before the first frame update
    void Start()
    {
        gameValues.paused = false;
        pausePanel.SetActive(gameValues.paused);
        SharedButtons.SetActive(gameValues.paused);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !loseText.activeInHierarchy)
        {
            Pause();
        }
    }

    public void Pause()
    {
        gameValues.paused = !gameValues.paused;

        if (gameValues.paused)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }

        pausePanel.SetActive(gameValues.paused);
        SharedButtons.SetActive(gameValues.paused);
    }
}