using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public Text honeyCountText;
    public Text objectiveText;
    public int numHoney = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Honey")
        {
            other.gameObject.SetActive(false);
            numHoney++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        honeyCountText.text = "Honey Pots: " + numHoney.ToString();
        if (numHoney == 3)
        {
            objectiveText.text = "Objective: Get Back to the Middle to Escape the Hive";
        }
    }
}
