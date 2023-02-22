using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public GameObject player;
    public GameObject playerCamera;
    public GameObject keypadObject;
    public GameObject doorClosed;
    public GameObject doorOpen;

    public GameObject keypadText;

    public Text keypadTextObject;
    public string answer = "132";

    public AudioSource AudioSource;
    public AudioClip AudioRight;
    public AudioClip AudioWrong;

    // Start is called before the first frame update
    void Start()
    {
        keypadObject.SetActive(false);
    }

    public void Number (int number)
    {
        keypadTextObject.text += number.ToString();
    }

    public void Enter()
    {
        if (keypadTextObject.text == answer)
        {
            AudioSource.PlayOneShot(AudioRight);
            keypadTextObject.text = "Correct";
        }
        else
        {
            AudioSource.PlayOneShot(AudioWrong);
            keypadTextObject.text = "Wrong";
        }
    }

    public void Clear()
    {
        keypadTextObject.text = "";
    }

    public void Exit()
    {
        keypadObject.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
        playerCamera.GetComponent<PlayerCamera>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (keypadTextObject.text == "Correct")
        {
            doorClosed.SetActive(false);
        }
        if (keypadObject.activeInHierarchy)
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            playerCamera.GetComponent<PlayerCamera>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            keypadText.SetActive(false);
        }
    }
}
