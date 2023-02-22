using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public GameObject gameOverMenu;
    
    private void OnEnable()
    {
        PlayerCaught.OnPlayerDeath += EnableGameOverMenu;
    }
    private void OnDisable()
    {
        PlayerCaught.OnPlayerDeath -= EnableGameOverMenu;
    }
    
    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }

    public void ResetTheGame()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("The button is working.");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}