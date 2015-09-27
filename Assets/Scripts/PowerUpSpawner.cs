using UnityEngine;
using System.Collections;

public class PowerUpSpawner : Spawner {

    public GameObject[] powerUpList;

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
        int index = Random.Range(0, length);
        
        return powerUpList[index];
    }
}
