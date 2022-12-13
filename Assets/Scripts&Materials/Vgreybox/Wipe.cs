using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wipe : MonoBehaviour
{
    private AudioSource sfx_Swipe;
  
    void OnTriggerEnter(Collider collisionData)
    {

        if (collisionData.gameObject.name == "RacoonTail")
        {
            sfx_Swipe = gameObject.GetComponentInParent<AudioSource>();
            sfx_Swipe.Play();
            Destroy(gameObject);
        }
       
    }

   
}


