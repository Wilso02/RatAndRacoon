using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Identify_Script : MonoBehaviour
{

    
    public IdentifyManager identifyManager;

    // Start is called before the first frame update
    void Start()
    {

        

    }

   

    public void OnMouseDown()
    {

        if (gameObject.name == "Mistake_1")
        {
            
            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 1!");
            identifyManager.AddScore();

        }

        else if(gameObject.name == "Mistake_2")
        {

            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 2!");
            identifyManager.AddScore();
        }

       else if(gameObject.name == "Mistake_3")
        {

            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 3!");
            identifyManager.AddScore();
        }

        else if(gameObject.name == "Mistake_4")
        {

            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 4!");
            identifyManager.AddScore();
        }

        else if (gameObject.name == "Mistake_5")
        {

            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 5!");
            identifyManager.AddScore();
        }

        else if (gameObject.name == "Mistake_6")
        {
            
            this.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("You Found a Mistake 6!");
            identifyManager.AddScore();

        }


    }    

}
