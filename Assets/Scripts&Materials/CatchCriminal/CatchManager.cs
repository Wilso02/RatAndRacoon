using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchManager : MonoBehaviour
{
    bool TimerEnded = false;

    void OnEnable() //enable called event
    {
        Shared_EventManager.EndOfMicroGame += TimerLength; //from the "Shared_EventsManager"
    }
    void OnDisable() //disable called event
    {
        Shared_EventManager.EndOfMicroGame -= TimerLength; //from the "Shared_EventsManager"
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void TimerLength()
    {

        TimerEnded = true;
        EndGame();

    }
    void EndGame()
    {
        
            print("Failure");
            Cursor.lockState = CursorLockMode.Locked;
            Shared_EventManager.GameOver();

        
    }
}
