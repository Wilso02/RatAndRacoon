using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charcter_Movement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        Vector3 characterPos = Camera.main.WorldToScreenPoint(transform.position);

        mousePos.x = mousePos.x - characterPos.x;
        mousePos.y = mousePos.y - characterPos.y;

        Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = 0;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);


    }
}
