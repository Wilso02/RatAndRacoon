using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyProximity : MonoBehaviour
{
    //checking to make sure the script is running correctly
    public int rubbishBlocking;

    //trigger for when the rubbish interacts with the boundaries
    void OnTriggerEnter(Collider RubbishRemoved)
    {
        //if the object dragged has the tag 'rubbish'
        if (RubbishRemoved.tag == "Rubbish")
        {
            //note that the program is working
            Debug.Log("Removed");
            //add to the score
            rubbishBlocking++;
            //add to the overall score
            EventManagerFind.AddScore();
        }
    }
}
