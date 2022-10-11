using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentifyMissing : MonoBehaviour
{
    public GameObject NewItem;
    public GameObject NewItem2;
    public GameObject ExistingItem;
    public GameObject ExistingItem2;
    public GameObject ExistingItem3; //make these into a list

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // when the player Left-Clicks and is on one of the different items
        if (Input.GetMouseButton(0) && NewItem)
        {
            Destroy(NewItem);
            Debug.Log("You found a lie!!");
       
        }

        // when the player Left-Clicks and is on one of the same items
        else if (Input.GetMouseButton(0) && ExistingItem)
        {

            Debug.Log("Oops Try Again!!");

        }


    }
}
