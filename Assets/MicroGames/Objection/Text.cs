using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    public Text gameStage;

    void OnEnable()
    {
        EventManager.talkingStage += Chatter;

    }

    void OnDisable()
    {
        EventManager.talkingStage -= Chatter;
    }

    void Chatter()
    {
        //gameStage.text = "Blah blah blah...";
    }
}
