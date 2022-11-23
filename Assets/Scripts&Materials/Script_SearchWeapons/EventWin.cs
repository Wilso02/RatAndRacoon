using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventWin : MonoBehaviour
{
    public void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            print("click!");
            //WeaponsManager.WinGame();
            FindObjectOfType<WeaponsManager>().WinGame();
        }
        
    }
}
