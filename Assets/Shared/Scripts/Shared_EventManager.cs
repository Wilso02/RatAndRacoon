using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shared_EventManager : MonoBehaviour
{


   //Event to end the timer function
    public delegate void EndOfTimer();
    public static event EndOfTimer EndOfMicroGame;

    public static void TimerDone() 
    {

        EndOfMicroGame();

    }
       
    //Event for a Time Lose Function
    public delegate void StopTheTimer();
    public static event StopTheTimer StopTimer;

    public static void TimerPause()
    {

        StopTimer();

    }

    //Event for the Lose Function
    public delegate void LosingEvent();
    public static event LosingEvent LostTheGame;

    public static void GameOver()
    {

        LostTheGame();

    }

    //Event for Win Function
    public delegate void WinningEvent();
    public static event WinningEvent GameCompleted;

    public static void GameWon()
    {

        GameCompleted();

    }
}
