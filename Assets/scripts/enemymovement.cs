using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public float speed;
    public GameObject explosion;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        explosion.GetComponent<ParticleSystem>().Play();
        Destroy(gameObject);
    }
}
