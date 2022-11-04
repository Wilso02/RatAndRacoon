using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectBridge : MonoBehaviour
{
    public ChaseManager chaseManager;



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "CorrectBridge")
        {

            Debug.Log("Correct");
            chaseManager.WinCondition = true;

        }
    }

}
