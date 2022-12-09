using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjButton : MonoBehaviour
{
    public enum GameState
    {
        talking,
        click,
        objection,
        tooLate,
        lose,
        win
    }
    public GameState gState;
    private bool simulate = true;
    Rigidbody rb;
    public int score;
    public GameObject objButton;
    GameObject buttonClone;
    public GameObject objStatement;
    GameObject statementClone;
    public Material[] materials;
    Renderer rend;
    bool GameWon = false;

    public Transform spawn;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        // rend.enable = true;
        // rend.sharedMaterial = materials(0);

    }

    // Update is called once per frame
    void Update()
    {
        //when the mouse is clicked, add to the score
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("working");
            score++;
        }

        if (simulate)
        {
            simulate = false;
            switch (gState)
            {
                case GameState.talking:
                    Debug.Log("do not click");
                 
                    //if the player has clicked early,
                    if (score >= 1)
                    {
                        //they lose
                        StartCoroutine(TransitionTimer(1f, GameState.lose));
                    }
                    else
                    {
                        //otherwise after a random time between 1-7 second, change state 
                        StartCoroutine(TransitionTimer(Random.Range(1f, 7f), GameState.click));
                    }
                    break;

                case GameState.click:
                    Debug.Log("click");
                    if (score >= 1)
                    {
                        //if they've clicked before this, they clicked too early and fail
                        Debug.Log("Too Early");
                        StartCoroutine(TransitionTimer(1f, GameState.lose));
                    }
                    else
                    {
                        //otherwise create an object to indicate to click
                        buttonClone = Instantiate(objButton, spawn);
                        StartCoroutine(TransitionTimer(1f, GameState.objection));
                    }
                    break;

                case GameState.objection:
                    if (score >= 1)
                    {
                        //if the player clicked, spawn the objection indicator
                        Destroy(buttonClone);
                        statementClone = Instantiate(objStatement, spawn);
                        Debug.Log("Objection!");
                        StartCoroutine(TransitionTimer(1f, GameState.win));
                    }
                    else
                    {
                        //otherwise the player loses
                        Destroy(buttonClone);
                        StartCoroutine(TransitionTimer(1f, GameState.tooLate));
                    }
                    break;

                case GameState.tooLate:
                    Debug.Log("too late");
                    StartCoroutine(TransitionTimer(1f, GameState.lose));
                    break;

                case GameState.win:
                    Debug.Log("Win");
                    GameWon = true;
                    Endgame();
                    break;

                case GameState.lose:
                    Debug.Log("Lose");
                    Endgame();
                    break;
            }
        }

    }
    IEnumerator TransitionTimer(float delay, GameState newState)
    {
        yield return new WaitForSeconds(delay);
        gState = newState;
        //wait till after phase.
        simulate = true;
    }

    void Endgame()
    {
        if (GameWon == true)
        {
            Shared_EventManager.GameWon();
        }
        else
        {
            Shared_EventManager.GameOver();
        }

    }
}
