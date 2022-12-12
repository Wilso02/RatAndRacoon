using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] private AudioSource wiping;
    Vector3 pos;
    public float offset = 3f;

    void Update()
    {
     //  wiping.Play();
        pos = Input.mousePosition;
        pos.z = offset;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }

}
