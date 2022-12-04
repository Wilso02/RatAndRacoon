using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IdentifyManager : MonoBehaviour
{
    

    public bool WinCondition = false;
    bool GameWon = false;
    bool TimerEnded = false;

    public TextMeshProUGUI Score;
    public int score = 0;

    private void OnEnable()
    {

        Shared_EventManager.EndOfMicroGame += TimerLength; //from the "Shared_EventsManager"

    }

    private void OnDisable()
    {

        Shared_EventManager.EndOfMicroGame -= TimerLength; //from the "Shared_EventsManager"

    }


    // Update is called once per frame
    void Update()
    {
        
        if(score == 6)
        {

            GameWon = true;

        }



    }

    public void AddScore()
    {

        score += 1;
        Score.text = "Mistake's Found: " + score + "/6";

    }


    void TimerLength()
    {

        TimerEnded = true;
        EndGame();

    }

    void EndGame()
    {
        if (GameWon == true && TimerEnded == true)
        {
            print("Winner");
            Shared_EventManager.GameWon();

        }
        else
        {
            print("Failure");
            Shared_EventManager.GameOver();

        }



    }
}
