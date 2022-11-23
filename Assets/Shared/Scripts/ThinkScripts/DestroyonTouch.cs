using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonTouch : MonoBehaviour
{

    public ThinkManager thinkManager;

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
        Destroy(this.gameObject);
        thinkManager.destroyIntrusive++;
        print("Intrusive Thoughts Destroyed: " + thinkManager.destroyIntrusive);
    }
}
