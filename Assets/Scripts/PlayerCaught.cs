using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCaught : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Barry"))
        {
            Debug.Log("Game Over");
            Cursor.lockState = CursorLockMode.None; 
            Cursor.visible = true;
            SceneManager.LoadScene(3);

        }
    }
}