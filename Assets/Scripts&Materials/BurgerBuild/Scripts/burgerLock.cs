using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burgerLock : MonoBehaviour
{
    public GameObject dragable;
    
    void OnTriggerEnter(Collider dragSnap)
    {
        if (dragSnap.gameObject == dragable)
        {
            Debug.Log("working");
            WinCondition.WinCount++;
            WinCondition.WinCheck();
            Destroy(dragable);
            Destroy(gameObject);
        }
    }

}
