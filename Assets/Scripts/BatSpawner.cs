using UnityEngine;
using System.Collections;

public class BatSpawner : Spawner {
    public GameObject bat;
    public int batCount = 0;
    private int maxBats = 100;

    // Use this for initialization
    void Start () {
        ringObj = GameObject.Find("ring");
        ringStats = ringObj.GetComponent<RotateRing>();
        SetSpawnObj(bat);
        StartSpawn();
    }

    void Update()
    {
        batCount = ringObj.transform.childCount - 2;
        if (batCount >= maxBats)
        {
            //Debug.Log("Max bats achieved");
            BroadcastMessage("StopSpawn", SendMessageOptions.DontRequireReceiver);
        }
        else
        {
            BroadcastMessage("ResumeSpawn", SendMessageOptions.DontRequireReceiver);
        }
       
    }

    public void changeMaxBats(int newCt)
    {
        maxBats = newCt;
    }
}
