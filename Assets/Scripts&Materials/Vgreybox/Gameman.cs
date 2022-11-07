using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameman : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Start is called before the first frame update
    void Update()
    {
        if (!GameObject.FindWithTag("Dust"))
        {

            SceneManager.LoadScene("");
        }
     
    }

  

}
