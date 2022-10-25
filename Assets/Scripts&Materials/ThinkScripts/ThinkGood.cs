using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinkGood : MonoBehaviour
{
    Vector2 randomPosition2;
    public float xRange = 3f;

    public float yRange = 3f;

    // Start is called before the first frame update
    void Start()
    {
        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float yPosition = Random.Range(0 - yRange, 0 + yRange);
        randomPosition2 = new Vector2(xPosition, yPosition);
        transform.position = randomPosition2;
        GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
