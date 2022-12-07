using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CappyCaught : MonoBehaviour
{

    void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.name == "Cappy")
            {
                Debug.Log("GOT YOU");
                FindObjectOfType<GameManger>().WinGame();
            }
         
        } 
    }
}