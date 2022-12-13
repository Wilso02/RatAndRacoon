using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMovement : MonoBehaviour
{
    Vector3 mousePositionOffset;
    public AudioSource sfx_Bridge;

   private Vector3 GetMouseWorldPosition()
    {
        //capture mouse position and return WorldPoint
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        //Capture the mouse
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
        Debug.Log("Drag ended!");
        sfx_Bridge.Play();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }
    
}
