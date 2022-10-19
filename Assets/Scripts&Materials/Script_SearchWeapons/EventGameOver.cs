using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventGameOver : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    /*void ToolClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            print("click");
            if (OnClicked != null)
                OnClicked();
        }
    }*/

    void OnMouseDown()
    {
        print("click!");
        if (OnClicked != null)
            OnClicked();
        //move plane to 2,3,-6 cause its wrong
    }
}
