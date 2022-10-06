using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField]
    private float maxSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        FollowMousePos();
    }

    private void FollowMousePos()
    {
        transform.position = GetworldPosFromMouse();

    }
    private Vector2 GetworldPosFromMouse()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition);

    }

}
