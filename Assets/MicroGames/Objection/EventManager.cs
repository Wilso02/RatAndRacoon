using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    //used for changing the colour
    //public delegate void colour();
    //public static event colour colSwap;

    //function used to call on the changing of colour
    //public static void ChangeState
    //{
    //col Swap(); //run the event to change the colour
    //}
    //Used for tracking the game stage
    public delegate void talking();
    public static event talking talkingStage;

    //function so that when the stage needs to be changed,
    public static void Chatter()
    {
        talkingStage();  //it progresses to the next stage
    }

}
