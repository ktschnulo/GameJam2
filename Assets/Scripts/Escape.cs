using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    public GameObject escapeInteractText1;
    public GameObject escapeInteractText2;
    public Text numHoneyText;
    public bool testing = false;

    public bool inReach;

    // Start is called before the first frame update
    void Start()
    {
        inReach = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            if (numHoneyText.text == "Honey Pots: 3")
            {
                escapeInteractText2.SetActive(true);
                testing = true;
            }
            else
            {
                escapeInteractText1.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            escapeInteractText1.SetActive(false);
            escapeInteractText2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            if (numHoneyText.text == "Honey Pots: 3")
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
