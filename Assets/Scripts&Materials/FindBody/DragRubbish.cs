using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRubbish : MonoBehaviour
{
    private Vector3 mOffset;
    //collects the z axis position of the game object
    private float mZCoord;
    [SerializeField] private AudioSource leafRussle;

    void OnMouseDown()
    {
        //locking in the z axis position for the game object
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        //mouse offset = game objects position in the world - mouse position in the world
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }


    private Vector3 GetMouseWorldPos()
    {
        //coordinates supplied by the mouses position, but doesn't include z axis
        Vector3 mousePoint = Input.mousePosition;
        //z axis position provided by the game object
        mousePoint.z = mZCoord;
        //combine them to world positions
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        leafRussle.Play();
        //move the object to the position created above
        transform.position = GetMouseWorldPos() + mOffset;
    }

    //function for removing the rubbish when dragged off the body
    void OnTriggerEnter(Collider RubbishRemoved)
    {
        //if the object with the tag 'dumpster' interacts with the rubbish
        if (RubbishRemoved.tag == "Dumpster")
        {
            //destroy the rubbish
            Destroy(gameObject);
        }
    }
}
