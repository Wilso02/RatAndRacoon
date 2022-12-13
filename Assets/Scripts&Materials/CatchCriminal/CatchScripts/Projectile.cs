using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    private Rigidbody _rb;
    public AudioSource sfx_Tackle;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void Fire(float speed, Vector3 direction)
    {
        _rb.velocity = direction * speed;
    }

    void OnCollisionEnter(Collision collisionData)
    {
        
        if(collisionData.collider.name == "Capybara")
        {
            sfx_Tackle.Play();
            print("Winner");
            //Cursor.lockState = CursorLockMode.Locked;
            Shared_EventManager.GameWon();
            Destroy(this.gameObject);
        }

        if (collisionData.collider.name == "Wall")
        {
            print("Failure");
            //Cursor.lockState = CursorLockMode.Locked;
            Shared_EventManager.GameOver();
            Destroy(this.gameObject);
        }


    }
}