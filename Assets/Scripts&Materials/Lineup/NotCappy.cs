using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotCappy : MonoBehaviour
{
    // Update is called once per frame
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))

        {
            Debug.Log("wrong guy");

            FindObjectOfType<GameManger>().GameFinished();
        }
    }
}

