using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    bool spawnenemy = false;
    float spawntimer;
    GameObject[] enemyspawnref;
    GameObject enemyspawnpointt;
    public GameObject enemyobj;

    void Start()
    {
        enemyspawnref = GameObject.FindGameObjectsWithTag("enemyspawner");
    }

    
    void Update()
    {
        int spawnnum = Random.Range(0, 4);
        spawntimer += Time.deltaTime;
        enemyspawnpointt = enemyspawnref[spawnnum];

        if (spawntimer > 4.0f)
        {
            spawnenemy = true;
        }
        
        if (spawnenemy == true)
        {
            GameObject clone = Instantiate(enemyobj);
            clone.transform.position = enemyspawnpointt.transform.position;
            clone.transform.localScale = enemyobj.transform.lossyScale;
            clone.transform.rotation = enemyobj.transform.rotation;
            spawnenemy = false;
            spawntimer = 0f;
        }
    }
}
