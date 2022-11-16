using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shared_Timer : MonoBehaviour
{
    public TextMeshProUGUI countdownText; //controls the text on the UI for the countdown
    private float countdownTime = 10.0f; // amount of time (Eg 10sec)
    private bool isCounting; // is the timer counting yet? Yes or No?

    private void OnEnable()
    {

        Shared_EventManager.StopTimer += TimerHasStopped;

    }

    private void OnDisable()
    {

        Shared_EventManager.StopTimer -= TimerHasStopped;

    }

    private void Awake()
    {

        isCounting = true; //when game begins timer starts counting
        StartCoroutine(Tick()); //start the timer

    }

    //The Timer Function
    IEnumerator Tick()
    {

        if (countdownTime <= 0.1f) // if the time is less then 0.1sec run event to see if player won or lost microgame
        {

            TimerCompleted();

        }

        else //otherwise tick down by one more second then repeat steps
        {

            yield return new WaitForSecondsRealtime(1f);

            countdownTime--;
            StartCoroutine(Tick());

        }

    }

    // Update is called once per frame
    void Update()
    {
        
        //prints time left on timer
        if((isCounting) && (countdownTime != 0.1f))
        {

            countdownText.text = countdownTime.ToString();

        }

    }

    //runs the timer completed event
    void TimerCompleted()
    {

        Shared_EventManager.TimerDone();

    }

    void TimerHasStopped()
    {

        isCounting = false;
        // Why?
        countdownTime = 20.0f;

    }



}
