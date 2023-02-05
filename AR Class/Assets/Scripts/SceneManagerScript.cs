using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void Resume()
    {
        SceneManager.LoadScene("Resume");
    }
    public void BirthdayCake()
    {
        SceneManager.LoadScene("BirthdayCard");
    }
    public void Building()
    {
        SceneManager.LoadScene("Building");
    }
    public void Stage()
    {
        SceneManager.LoadScene("Stage");
    }
    public void MidAir()
    {
        SceneManager.LoadScene("Mid Air");
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
}

    
