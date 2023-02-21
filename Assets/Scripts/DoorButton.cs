using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public GameObject door;
    public GameObject buttonInteractText;

    public bool inReach;
    public bool state = false;
    public bool countdown = false;
    public float timeLeft = 8;

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
        if (countdown == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                door.SetActive(false);
            }
            else
            {
                door.SetActive(true);
                countdown = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            timeLeft = 8;
            door.SetActive(false);
            countdown = true;
            
        }
    }
}
