using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    

    public void ResetTheGame()
    {
            SceneManager.LoadScene(1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("The button is working.");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}