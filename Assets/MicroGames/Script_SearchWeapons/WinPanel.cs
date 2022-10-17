using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    void OnEnable()
    {
        EventWin.OnClicked += Win;
    }

    void OnDisable()
    {
        EventWin.OnClicked -= Win;
    }

    void Win()
    {
        Vector3 pos = transform.position;
        pos.x = 2;
        pos.y = 3;
        pos.z = -6;
        transform.position = pos;
    }
}
