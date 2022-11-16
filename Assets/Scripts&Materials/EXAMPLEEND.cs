using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXAMPLEEND : MonoBehaviour
{
    bool GameWon = false;
    bool TimerEnded = false;

    // Start is called before the first frame update
    void OnEnable()
    {
        // THE LAST WORD ON THIS LINE SHOULD REFERENCE A FUNCTION IN THIS SCRIPT TO HAPPEN WHEN THE TIMER REACHES 0
        Shared_EventManager.EndOfMicroGame += TimerLength;
    }

    void OnDisable()
    {
        // THIS SHOULD BE THE SAME BUT WITH A -
        Shared_EventManager.EndOfMicroGame -= TimerLength;
    }

    void Update()
    {
        if (!GameObject.FindWithTag("Dust"))
        {
            GameWon = true;
            Endgame();
        }

    }
    
    // THIS IS THE FUNCTION REFERENCE IN ONENABLE AND SHOULD EITHER DEAL WITH THE END STATUS OR SEND THE FLOW TO A FUNCTION THAT DOES
    void TimerLength()
    {
        TimerEnded = true;
        Endgame();
    }

    void Endgame()
    {
        if (GameWon == true)
        {
            // IF WHEN YOU GET TO THE END HERE YOU HAVE WON, CALL THIS EXACTLY
            Shared_EventManager.GameWon();
        }
        else 
        {
            // IF YOU GET TO THE END AND YOU HAVE LOST, CALL THIS EXACTLY
            Shared_EventManager.GameOver();
        }
    }
}
