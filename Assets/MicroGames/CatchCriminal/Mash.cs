using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mash : MonoBehaviour
{

    public float mashDelay = 5f;

    float ButtonMash;
    bool pressed;
    bool started;

    // Start is called before the first frame update
    void Start()
    {
        ButtonMash = mashDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            started = true;
        }

        if (started)
        {
            ButtonMash -= Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space) && !pressed)
            {
                pressed = true;
                ButtonMash = mashDelay;
                mashDelay++;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                pressed = false;
             

            }

            if(mashDelay > 0)
            {
                mashDelay -= Time.deltaTime;
                
            }

            if (ButtonMash <= 0)
            {
                GetComponent<Renderer>().material.color = Color.red;
                print("he got away");
            }

            if (ButtonMash >= 30)
            {
                GetComponent<Renderer>().material.color = Color.green;
                print("gotem");
            }
        }
        
    }
}
