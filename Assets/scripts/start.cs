using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public GameObject startbutton;
    public GameObject instructionsbutton;
    public GameObject ingameui;
    public GameObject instructionspage;
    public GameObject mainmenuui;
    public GameObject backbutton;
    public GameObject enemymovement;
    public GameObject enemyspawn;
    public GameObject player;
    public GameObject ingameuiscript;
    public GameObject ingameuiscript1;
    public GameObject ingameuiscript2;
    public GameObject ingameuiscript3;
    public GameObject bulletscript;
    public GameObject scorescript;
    void Start()
    {
        startbutton.GetComponent<Button>().onClick.AddListener(startOnClick);
        instructionsbutton.GetComponent<Button>().onClick.AddListener(instructionsClick);
        backbutton.GetComponent<Button>().onClick.AddListener(backonclick);
        player.GetComponent<playermovement>().enabled = false;
        enemymovement.GetComponent<enemymovement>().enabled = false;
        scorescript.GetComponent<score>().enabled = false;
        bulletscript.GetComponent<bullet>().enabled = false;
        ingameuiscript.GetComponent<beatmechanic>().enabled = false;
        ingameuiscript1.GetComponent<beatmechanic>().enabled = false;
        ingameuiscript2.GetComponent<beatmechanic>().enabled = false;
        ingameuiscript3.GetComponent<beatmechanic>().enabled = false;
        enemyspawn.GetComponent<enemy>().enabled = false;
    }

    void startOnClick()
    {
        mainmenuui.SetActive(false);
        ingameui.SetActive(true);
        player.GetComponent<playermovement>().enabled = true;
        enemymovement.GetComponent<enemymovement>().enabled = true;
        scorescript.GetComponent<score>().enabled = true;
        bulletscript.GetComponent<bullet>().enabled = true;
        ingameuiscript.GetComponent<beatmechanic>().enabled = true;
        ingameuiscript1.GetComponent<beatmechanic>().enabled = true;
        ingameuiscript2.GetComponent<beatmechanic>().enabled = true;
        ingameuiscript3.GetComponent<beatmechanic>().enabled = true;
        enemyspawn.GetComponent<enemy>().enabled = true;
    }

    void instructionsClick()
    {
        mainmenuui.SetActive(false);
        instructionspage.SetActive(true);
    }

    void backonclick()
    {
        instructionspage.SetActive(false);
        mainmenuui.SetActive(true);
    }
}
