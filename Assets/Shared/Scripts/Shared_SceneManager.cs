using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shared_SceneManager : MonoBehaviour
{
    private bool sceneChange; // this checks if we are changing scenes in the next order.
    private bool sceneRetry; //this determines whether we are repaeating the same scene due to a lose.


    public GameObject FailedBTN; //LoseButton or LoseScreen
    public GameObject WinBTN; //WinButton or WinScreen
    public Image endImage;
    public Sprite winSprite;
    public Sprite loseSprite;

    public bool oldMode = false;

    //these events help with determing whether the game wins or loses,
    //if lost in your game the script will run the complete game event in your games script,
    //if lost in your game run the lost game event in your game script.
    private void OnEnable()
    {
        Shared_EventManager.GameCompleted += ProgressStartSwapTimer; //called from the Shared_EventManager script
        Shared_EventManager.LostTheGame += StartRetryTimer; // from the Shared_EventManager script
    }

    private void OnDisable()
    {
        Shared_EventManager.GameCompleted -= ProgressStartSwapTimer; //called from the Shared_EventManager script
        Shared_EventManager.LostTheGame -= StartRetryTimer; // from the Shared_EventManager script
    }



    // Start is called before the first frame update
    void Start()
    {
        if (oldMode) {
            FailedBTN.SetActive(false); //failed button not active
            WinBTN.SetActive(false); //win button not active
        }
        sceneChange = false; //SceneChange not active
        sceneRetry = false; //SceneRetry not active
    }

    // Update is called once per frame
    void Update()
    {
        
        if(sceneChange == true)
        {
            float delayForSceneSwap = 3f;
            StartCoroutine(LoadNewSceneAfterDelay(delayForSceneSwap));
        }

        if(sceneRetry == true)
        {

            float delayForSceneSwap = 3f;
            StartCoroutine(LoadSameSceneAfterDelay(delayForSceneSwap));

        }

    }

    IEnumerator LoadNewSceneAfterDelay(float delayForSceneSwap)
    {
        yield return new WaitForSeconds(delayForSceneSwap);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator LoadSameSceneAfterDelay(float delayForSceneSwap)
    {
        yield return new WaitForSeconds(delayForSceneSwap);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void ProgressStartSwapTimer()
    {
        Debug.Log("I think this is where you win?");
        if (oldMode) {
            WinBTN.SetActive(true);
        } else {
            Debug.Log("CHANGE THE SPRITE PLS");
            endImage.sprite = winSprite;
            endImage.color = new Color32(255,255,225,255);
        }
        sceneChange = true;

    }

    void StartRetryTimer()
    {
        Debug.Log("I think this is where you lose?");
        if (oldMode) {
            FailedBTN.SetActive(true);
        } else {
            Debug.Log("CHANGE THE SPRITE PLS");
            endImage.sprite = loseSprite;
            endImage.color = new Color32(255,255,225,255);
        }
        sceneRetry = true;

    }

}
