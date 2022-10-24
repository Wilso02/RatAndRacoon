using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicking : MonoBehaviour
{

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.name == "Cappy")
            {
                Debug.Log("GOT YOU");
            }
            else
            {
                Debug.Log("wrong guy");
            }
        }
    }
}