using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameManager : MonoBehaviour
{
    //the score for the micro game
    public int rubbishRemoved;

    //allow the event manager and this script to interact when asked
    void OnEnable()
    {
        EventManagerFind.rubbishDestroyed += AddScore;
    }

    //otherwise don't interact
    void OnDisable()
    {
        EventManagerFind.rubbishDestroyed -= AddScore;
    }

    //adding to the score when called 
    void AddScore()
    {
        rubbishRemoved++;
        //if 5 or more rubbish removed,
        if (rubbishRemoved >= 5)
        {
            //win condition met
            Debug.Log("Win");
        }
    }
}
