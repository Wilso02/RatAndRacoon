using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusty : MonoBehaviour
{
    ParticleSystem Dust;
    // Start is called before the first frame update
    void Start()
    {
        Dust = GetComponent<ParticleSystem>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider gameObject)

    { if (gameObject.name == "RacoonTail")
        { Dust.Play();
        }
    
    }
}
