using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shared_Lives : MonoBehaviour
{

    private int playersLives;

    public GameObject livesUI_1;
    public GameObject livesUI_2;
    public GameObject livesUI_3;

    void OnEnable()
    {

        Shared_EventManager.GameCompleted += IncreaseLives;
        Shared_EventManager.LostTheGame += DecreaseLives;
        
    }

    private void OnDisable()
    {

        Shared_EventManager.GameCompleted -= IncreaseLives;
        Shared_EventManager.LostTheGame -= DecreaseLives;
        
    }

    private void Awake()
    {

        //set int playerLives to obtain the pref int
        playersLives = PlayerPrefs.GetInt("Lives");

    }

    // Start is called before the first frame update
    void Start()
    {
        
        if(playersLives == 3)
        {

            ThreeLivesDisplayed();

        }

        else if(playersLives == 2)
        {

            TwoLivesDisplayed();

        }

        else if(playersLives == 1)
        {

            OneLivesDisplayed();

        }


    }

    void ThreeLivesDisplayed()
    {

        livesUI_1.SetActive(true);
        livesUI_2.SetActive(true);
        livesUI_3.SetActive(true);

    }

    void TwoLivesDisplayed()
    {

        livesUI_1.SetActive(true);
        livesUI_2.SetActive(true);
        livesUI_3.SetActive(false);
        
    }

    void OneLivesDisplayed()
    {

        livesUI_1.SetActive(true);
        livesUI_2.SetActive(false);
        livesUI_3.SetActive(false);

    }

    void IncreaseLives()
    {
        //Sets the player prefs int to 3 which we'll use for the lives
        PlayerPrefs.SetInt("Lives", 3);

    }

    void DecreaseLives()
    {

        playersLives--;
        print(playersLives);
        PlayerPrefs.SetInt("Lives", playersLives);
        LoseScreen();

    }

    void LoseScreen()
    {

        if(playersLives <= 0)
        {

            PlayerPrefs.SetInt("Lives", 3);
            SceneManager.LoadScene("LoseScene");

        }

    }
   
}
