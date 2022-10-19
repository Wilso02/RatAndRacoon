using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventWin : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    void OnMouseDown()
    {
        print("click!");
        if (OnClicked != null)
            OnClicked();
    }
}
