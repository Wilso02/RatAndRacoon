using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wipe : MonoBehaviour
{



    
void OnTriggerEnter(Collider collisionData)
    {

        if (collisionData.gameObject.name == "RacoonTail")
        {
          
            Destroy(gameObject);


        }
       
    }

   
}


