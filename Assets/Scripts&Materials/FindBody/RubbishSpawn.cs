using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbishSpawn : MonoBehaviour
{
    //the number of rubbish to spawn
    public int numberOfRubbish;
    //the game object to spawn in
    public GameObject rubbish;


    // Start is called before the first frame update
    void Start()
    {
        //if the number of rubbish bags is less than wanted,
        for (int i = 0; i < numberOfRubbish; i++)
        {
            //chose a random position between          x 2 and -2,          y  4 and -4, and  z -1
            Vector3 randomPosition = new Vector3(Random.Range(2, -2), Random.Range(4, -4), -1);
            //and spawn a rubbish bag
            Instantiate(rubbish, randomPosition, Quaternion.identity);
        }

    }
}
