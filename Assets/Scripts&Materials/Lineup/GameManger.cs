using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    bool gameWon = false;

    void Start()
    {
        Cursor.visible = true;
    }
    

    // OnEnable and OnDisable just link this GameFinished function to the event that gets called when the timer runs out. 
    // If you do not include these lines there simply is no trimer
    void OnEnable()
    {
        Shared_EventManager.EndOfMicroGame += GameFinished;
    }

    void OnDisable()
    {
        Shared_EventManager.EndOfMicroGame -= GameFinished;
    }

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
    public void GameFinished()
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


