using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
