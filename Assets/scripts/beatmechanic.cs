using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beatmechanic : MonoBehaviour
{
    RectTransform beatlinepos;
    float beattimer;
    void Start()
    {
        beatlinepos = gameObject.GetComponent<RectTransform>();
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
            beattimer += Time.deltaTime;

            if(gameObject.CompareTag("beatlineleft"))
            {
                beatlinepos.localPosition += new Vector3(4.5f,0f,0f);
            }

            if(gameObject.CompareTag("beatlineright"))
            {
                beatlinepos.localPosition += new Vector3(-4.5f,0f,0f);
            }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(gameObject.CompareTag("beatlineright"))
        {
            beatlinepos.localPosition = new Vector3(200.0f,-168.3f,0f);
        }

        if(gameObject.CompareTag("beatlineleft"))
        {
            beatlinepos.localPosition = new Vector3(-200.0f,-168.3f,0f);
        }
    }
}
