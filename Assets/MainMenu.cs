using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartSimulation()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitSimulation()
    {
        Application.Quit();
    }
}
