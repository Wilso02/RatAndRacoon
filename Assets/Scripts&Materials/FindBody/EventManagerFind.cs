using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerFind : MonoBehaviour
{
    //score for the microgame
    public delegate void score();
    //tracking the score
    public static event score rubbishDestroyed;

    //the function called upon to add to the score
    public static void AddScore()
    {
        rubbishDestroyed();
    }
}
