using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    int playerstate = 0;
    float animtimer = 0;
    float beattime = 0;
    float movetime = 0;
    public bool moveab = false;
    public GameObject plbullet;
    public GameObject plshootboxobj;
    public GameObject shootps;
    public GameObject explosion;
    void Start()
    {

    }

    void Update()
    {
        animtimer += Time.deltaTime;
        beattime += Time.deltaTime;
        movetime += Time.deltaTime;
        explosion.transform.position = gameObject.transform.position;

        if(beattime > 0.4)
        {
            beattime = 0;
        }

        if (movetime > 0.55)
        {
            movetime = beattime;
            moveab = false;
        }

        if (movetime > 0.25)
        {
            moveab = true;
            Debug.Log(beattime);
        }

        if (Input.GetKeyDown("a") && playerstate == 0 && animtimer > 0.15 && moveab == true)
        {
            gameObject.GetComponent<Animator>().PlayInFixedTime("playermoveleft");
            playerstate += 1;
            animtimer = 0;
        }

        if (Input.GetKeyDown("a") && playerstate == 1 && animtimer > 0.15 && moveab == true)
        {
            gameObject.GetComponent<Animator>().PlayInFixedTime("playermoveleftmost");
            playerstate += 1;
        }

        if (Input.GetKeyDown("d") && playerstate == 2 && animtimer > 0.15 && moveab == true)
        {
            gameObject.GetComponent<Animator>().PlayInFixedTime("playermoveleftmostreverse");
            playerstate -= 1;
            animtimer = 0;
        }

        if (Input.GetKeyDown("d") && playerstate == 1 && animtimer > 0.15 && moveab == true)
        {
            gameObject.GetComponent<Animator>().PlayInFixedTime("playermoveleftreverse");
            playerstate -= 1;
            animtimer = 0;
        }

        if (Input.GetKeyDown("d") && playerstate == 0 && animtimer > 0.15 && moveab == true)
        {
            gameObject.GetComponent<Animator>().PlayInFixedTime("playermoveright");
            playerstate -= 1;
            animtimer = 0;
        }

        if (Input.GetKeyDown("d") && playerstate == -1 && animtimer > 0.15 && moveab == true)
        {
            gameObject.GetComponent<Animator>().PlayInFixedTime("playermoverightmost");
            playerstate -= 1;
            animtimer = 0;
        }

        if (Input.GetKeyDown("a") && playerstate == -2 && animtimer > 0.15 && moveab == true)
        {
            gameObject.GetComponent<Animator>().PlayInFixedTime("playermoverightmostreverse");
            playerstate += 1;
            animtimer = 0;
        }

        if (Input.GetKeyDown("a") && playerstate == -1 && animtimer > 0.15 && moveab == true)
        {
            gameObject.GetComponent<Animator>().PlayInFixedTime("playermoverightreverse");
            playerstate += 1;
            animtimer = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space) && moveab == true)
        {
            shootps.GetComponent<ParticleSystem>().Play();
            GameObject plbulletclone = Instantiate(plbullet);
            plbulletclone.transform.position = plshootboxobj.transform.position;
            plbulletclone.transform.rotation = plshootboxobj.transform.rotation;
            plbulletclone.GetComponent<Rigidbody>().velocity = plshootboxobj.transform.forward * -9;
            Destroy(plbulletclone, 10.0f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        explosion.GetComponent<ParticleSystem>().Play();
        Destroy(gameObject);
    }
}
