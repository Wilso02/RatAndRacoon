using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectBridge : MonoBehaviour
{
    public GameObject[] spawnChoices;
    public GameObject correctChoice;


    // Start is called before the first frame update
    void Start()
    {
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
      

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
    
        Debug.Log("Trigger");


    }

    
}
