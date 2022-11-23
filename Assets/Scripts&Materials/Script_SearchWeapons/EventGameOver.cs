using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventGameOver : MonoBehaviour
{
    public void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            print("click! wrong one!");
            //WeaponsManager.GameFinished();
            FindObjectOfType<WeaponsManager>().GameFinished();
        }
    }
}
