using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinkGood : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        print("Failure");
        //Cursor.lockState = CursorLockMode.Locked;
        Shared_EventManager.GameOver();
    }
}
