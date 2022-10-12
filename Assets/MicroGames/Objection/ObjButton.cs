using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjButton : MonoBehaviour
{
    public enum GameState
    {
        talking,
        objection,
        tooLate,
        lose,
        win
    }
    public GameState gState;
    private bool simulate = true;

    public GameObject objButton;
    public Material[] materials;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
       // rend.enable = true;
       // rend.sharedMaterial = materials(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (simulate)
        {
            simulate = false;
            switch (gState)
            {
                case GameState.talking:
                    Debug.Log("do not click");
                    if (Input.GetMouseButtonDown(0))
                    {

                        StartCoroutine(TransitionTimer(1f, GameState.lose));
                    }
                    else
                    {
                        StartCoroutine(TransitionTimer(Random.Range(1f, 7f), GameState.objection));
                    }
                        break;

                case GameState.objection:
                    Debug.Log("click");
                    if (Input.GetMouseButtonDown(0))
                    {
                        StartCoroutine(TransitionTimer(1f, GameState.win));
                    }
                    else
                    {
                        StartCoroutine(TransitionTimer(1f, GameState.tooLate));
                    }
                    break;

                case GameState.tooLate:
                    Debug.Log("too late");
                    if (Input.GetMouseButtonDown(0))
                    {
                        StartCoroutine(TransitionTimer(1f, GameState.lose));
                    }
                    else
                    {
                        StartCoroutine(TransitionTimer(1f, GameState.lose));
                    }
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


    //if (Input.GetMouseButtonDown(0))
    // {
    //     Debug.Log("Working");
    //  }
}
