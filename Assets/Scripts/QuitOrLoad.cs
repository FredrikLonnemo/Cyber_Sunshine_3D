using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitOrLoad : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void LoadByIndex(int sceneIndex)
    {
        Debug.Log("Loading scene" + sceneIndex);
        SceneManager.LoadScene(sceneIndex);
    }
}
