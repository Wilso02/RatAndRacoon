using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunsLockIn : MonoBehaviour
{
    public GameObject Buns;
    public GameObject bunsPlaceholder;
    
    void OnTriggerEnter(Collider BunSnap)
    {
        if (BunSnap.tag == "buns")
        {
            Debug.Log("working");
            //move the Buns object to bunsPlaceholder
            //BunSnap.transform.position = new Vector3(0f, 10.44f, 0f);
            //Buns.transform.position = bunsPlaceholder.transform.position;

            //stop the Buns object from being able to move
            //Destroy(Buns.GetComponent<Dragger>());
            WinCondition.WinCount++;
            WinCondition.WinCheck();
            Destroy(Buns);
            Destroy(bunsPlaceholder);


            //Add to the win condition counter
        }
    }

}
