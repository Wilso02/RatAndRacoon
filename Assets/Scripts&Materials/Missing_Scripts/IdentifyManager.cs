using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IdentifyManager : MonoBehaviour
{
    

    public bool WinCondition = false;
    bool gameWon = false;
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
        if(score == 5)
        {
            WinGame();
        }
    }

    public void AddScore()
    {
        score += 1;
        Score.text = "Mistake's Found: " + score + " out of 5";
    }


    void TimerLength()
    {
        TimerEnded = true;
        GameFinished();
    }

    /*void EndGame()
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
    }*/

    // A public function you can call to trigger a win. 
    // It sets GameWon to true and calls GameFinished
    public void WinGame()
    {
        gameWon = true;
        GameFinished();
    }

    // GameFinished can be called at any time. 
    // If WinGame was the function that led to this, GameWon is true and therefore it triggers the event manager for winning. 
    // In any other situation it triggers the fail section of the event manager
    void GameFinished() 
    {
        if (gameWon == true)
        {
            Shared_EventManager.GameWon();
        }
        else
        {
            Shared_EventManager.GameOver();
        } 
    }
}
