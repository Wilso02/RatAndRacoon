using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameman : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Start is called before the first frame update
    void Start()
    {

        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Dust");

        if (gameObjects.Length == 0)
        {
            Debug.Log("win");
        }
    }

  

}
