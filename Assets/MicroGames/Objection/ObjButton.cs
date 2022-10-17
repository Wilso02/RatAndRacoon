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
    public Material[] materials;
    Renderer rend;


    //void OnEnable()
    //{
    //EventManager.colSwap += ChangeMat;
    //}

    //void OnDisable()
    //{
    //EventManager.colSwap -= ChangeMat
    //}

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
                    EventManager.Chatter();

                    if (score >= 1)
                    {

                        StartCoroutine(TransitionTimer(1f, GameState.lose));
                    }
                    else
                    {
                        StartCoroutine(TransitionTimer(Random.Range(1f, 7f), GameState.click));
                    }
                    break;

                case GameState.click:
                    Debug.Log("click");
                    if (score >= 1)
                    {
                        Debug.Log("Too Early");
                        StartCoroutine(TransitionTimer(1f, GameState.lose));
                    }
                    else
                    {
                        StartCoroutine(TransitionTimer(1f, GameState.objection));
                    }
                    break;

                case GameState.objection:
                    if (score >= 1)
                    {
                        Debug.Log("Objection!");
                        StartCoroutine(TransitionTimer(0.5f, GameState.win));
                    }
                    else
                    {
                        StartCoroutine(TransitionTimer(1f, GameState.tooLate));
                    }
                    break;

                case GameState.tooLate:
                    Debug.Log("too late");
                    StartCoroutine(TransitionTimer(1f, GameState.lose));
                    break;

                case GameState.win:
                    Debug.Log("Win");
                    break;

                case GameState.lose:
                    Debug.Log("Lose");
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
}
