using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Identify_Script : MonoBehaviour
{
    bool collided = false;
    public IdentifyManager identifyManager;

    // Start is called before the first frame update
    void Start()
    {

        

    }

    private void OnMouseDown()
    {
        
            Debug.Log("You Found a Mistake!");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        collided = true;
        gameObject.SetActive(false);


    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        collided = false;

    }

}
