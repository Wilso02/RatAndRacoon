using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Identify_Script : MonoBehaviour
{

    
    public IdentifyManager identifyManager;
    public TextMeshProUGUI Score;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {

        

    }

    private void Update()
    {
        if(score == 6)
        {

            identifyManager.WinCondition = true;

        }

        Score.text = "Mistake's Found: " + score + "/6";

    }

    private void OnMouseDown()
    {

        if (gameObject.name == "Mistake_1")
        {
            
            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 1!");
            score += 1;

        }

        else if(gameObject.name == "Mistake_2")
        {

            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 2!");
            score += 1;
        }

       else if(gameObject.name == "Mistake_3")
        {

            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 3!");
            score += 1;
        }

        else if(gameObject.name == "Mistake_4")
        {

            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 4!");
            score += 1;
        }

        else if (gameObject.name == "Mistake_5")
        {

            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 5!");
            score += 1;
        }

        else if (gameObject.name == "Mistake_6")
        {
            
            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 6!");
            score += 1;

        }

    }    

}
