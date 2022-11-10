using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gameman : MonoBehaviour
{
    
    bool GameWon = false;
    bool TimerEnded = false;

    // Start is called before the first frame update
  void OnEnable()
    {
        Shared_EventManager.EndOfMicroGame += TimerLength;
    }

    void OnDisable()
    {
        Shared_EventManager.EndOfMicroGame -= TimerLength;
    }

    void Update()
    {
        if (!GameObject.FindWithTag("Dust"))
        {
            GameWon = true;
           
        }

    }
        void TimerLength()
        {
            TimerEnded = true;
            Endgame();


        }

        void Endgame()
        {
            if (GameWon == true && TimerEnded == true)
            {
                Shared_EventManager.GameWon();
            }
         else 
            {
           Shared_EventManager.GameOver();
            }
    

        }
    
}
