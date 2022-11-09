using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunsLockIn : MonoBehaviour
{

    GameObject Buns;
    GameObject bunsPlaceholder;
    
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider BunSnap)
    {
        if (BunSnap.tag == "buns")
        {
            Debug.Log("working");
            //move the Buns object to bunsPlaceholder
            Buns.transform.position = new Vector3(0f, 10.44f, 0f);
            //Buns.transform.position = bunsPlaceholder.transform.position;

            //stop the Buns object from being able to move
            
            //Add to the win condition counter
            WinCondition.WinCount =+ 1;
            print("win count is now" + WinCondition.WinCount);
        }
    }

}
