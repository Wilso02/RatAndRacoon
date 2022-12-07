using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinkGood : MonoBehaviour
{
    [SerializeField] private AudioSource popThought;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        print("Failure");
        popThought.Play();
        //Cursor.lockState = CursorLockMode.Locked;
        Shared_EventManager.GameOver();
    }
}
