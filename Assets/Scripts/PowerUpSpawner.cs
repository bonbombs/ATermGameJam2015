using UnityEngine;
using System.Collections;
using System;

public class PowerUpSpawner : Spawner {

    public GameObject[] powerUpList;
    public AudioSource audio;

	// Use this for initialization
	void Start () {
        ringObj = GameObject.Find("ring");
        SetSpawnObj(randomizePowerUp());
        StartSpawn();
    }

    void Update ()
    {
        SetSpawnObj(randomizePowerUp());
    }

    // Returns a random PowerUp object
    GameObject randomizePowerUp()
    {
        int length = powerUpList.Length;
        int index = UnityEngine.Random.Range(0, length);
        
        return powerUpList[index];
    }

    public override void SpawnFaster()
    {
        //Do something????
    }
}
