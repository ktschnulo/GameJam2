using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject buttonInteractText;

    public AudioSource AudioSource;
    public AudioClip Audio;
    public bool inReach;
    public bool state = false;

    

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
            buttonInteractText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            buttonInteractText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            AudioSource.PlayOneShot(Audio);
            if (state == true)
            {
                
                door1.SetActive(true);
                door2.SetActive(false);
                state = false;
            }
            else
            {
                door1.SetActive(false);
                door2.SetActive(true);
                state = true;
            }
        }
    }
}
