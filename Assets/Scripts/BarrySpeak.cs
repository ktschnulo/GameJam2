using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrySpeak : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip Speak;
    public float DialogueTime;
    private  bool toggle = true;
    // Update is called once per frame
   void OnTriggerStay(Collider other){
    if(other.CompareTag("Player") && toggle == true){
        Audio.PlayOneShot(Speak);
        toggle = false;
        
        StartCoroutine(WaitNextPlay());
    }
   }

   IEnumerator WaitNextPlay(){
    yield return new WaitForSeconds(DialogueTime);
    toggle = true;
   }
}
