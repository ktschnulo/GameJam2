using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
   public AudioSource ya_like_jazz;

   void OnTriggerEnter(){
    GetComponent<BoxCollider>().enabled = false;
    ya_like_jazz.Play();

   }
}
