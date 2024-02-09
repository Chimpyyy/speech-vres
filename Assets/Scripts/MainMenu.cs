using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //{FOR MAIN MENU --START--}
    public void StartSimulation()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void QuitSimulation()
    {
        Application.Quit();
    }
    //{FOR MAIN MENU --END--}



    //{FOR PATIENT ASSESSMENT --START--}
    public void StartPatientassessment()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void StartPatientassessment2()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void StartPatientassessment3and4()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void StartPatientassessment5()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void StartPatientassessment6()
    {
        SceneManager.LoadSceneAsync(6);
    }
    //{FOR PATIENT ASSESSMENT --END--}



    //{FOR RAPID EXTRICATION --START--}
    public void StartRapidExtrication1()
    {
        SceneManager.LoadSceneAsync(7);
    }

    public void StartRapidExtrication2()
    {
        SceneManager.LoadSceneAsync(8);
    }

    public void StartRapidExtrication3()
    {
        SceneManager.LoadSceneAsync(9);
    }

    public void StartRapidExtrication4()
    {
        SceneManager.LoadSceneAsync(10);
    }
    //{FOR RAPID EXTRICATION --END--}
}
