using UnityEngine;
using System.Collections;
using System;

public class BatSpawner : Spawner {

    public GameObject bat;
    public int batCount = 0;
    private int maxBats = 100;
    private ScoreCounter scoreCounter;

    // Use this for initialization
    void Start () {
        ringObj = GameObject.Find("ring");
        ringStats = ringObj.GetComponent<RotateRing>();
        scoreCounter = FindObjectOfType<ScoreCounter>();
        SetSpawnObj(bat);
        StartSpawn();
    }

    void Update()
    {
        batCount = transform.childCount;
        scoreCounter.BroadcastMessage("UpdateHealth", batCount);
        if (batCount >= maxBats)
        {
            //Debug.Log("Max bats achieved");
            //LOSE?
            Application.LoadLevel("LoseScreen");
            BroadcastMessage("StopSpawn", SendMessageOptions.DontRequireReceiver);
        }
        else
        {
            BroadcastMessage("ResumeSpawn", SendMessageOptions.DontRequireReceiver);
        }
       
    }

    public override void SpawnFaster()
    {
        multiplier++;
    }

    public void changeMaxBats(int newCt)
    {
        maxBats = newCt;
    }
}
