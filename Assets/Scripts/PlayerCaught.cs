using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCaught : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Barry"))
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(3);
        }
    }
}