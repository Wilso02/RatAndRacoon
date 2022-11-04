using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseManager : MonoBehaviour
{
    public GameObject[] spawnChoices;
    public GameObject correctChoice;

    public bool WinCondition = false;
    bool GameWon = false;
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
        Cursor.lockState = CursorLockMode.None;

        //Generate a Random Correct Answer within an Array of objects
        spawnChoices = GameObject.FindGameObjectsWithTag("BridgeChoice");
        int RandomIndex = Random.Range (0,spawnChoices.Length);
        correctChoice = spawnChoices[RandomIndex];
        print (correctChoice.name);

        correctChoice.tag = "CorrectBridge";

    }

    // Update is called once per frame
    void Update()
    {
        //If the correct bridge was selected through collision
        if(WinCondition == true)
        {

            GameWon = true;

        }

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
            Cursor.lockState = CursorLockMode.Locked;
            Shared_EventManager.GameWon();
            
        }
        else
        {
            print("Failure");
            Cursor.lockState = CursorLockMode.Locked;
            Shared_EventManager.GameOver();

        }



    }

}
