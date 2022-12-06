using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives_Reset : MonoBehaviour
{
    void OnMouseDown()
    {
        Shared_Lives.playersLives = 3;
    }
    
}
