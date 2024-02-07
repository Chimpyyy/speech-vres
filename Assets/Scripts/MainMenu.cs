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
    public void StartPatientassessment()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void StartPatientassessment2()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void StartPatientassessment3()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void StartRapidExtrication1()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void QuitSimulation()
    {
        Application.Quit();
    }
}
