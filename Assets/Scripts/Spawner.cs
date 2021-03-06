﻿using UnityEngine;
using System.Collections;

public abstract class Spawner : MonoBehaviour
{
    public float radius;
    public float spawnTime = 3f;

    protected float multiplier = 1f;
    protected GameObject ringObj;
    protected RotateRing ringStats;

    private GameObject spawnObj;      //Object to spawn around circle
    private bool isPaused = false;
    private Vector3 center;
    
    // Use this for initialization
    void Start()
    {
        center = transform.position;
    }

    public void SetSpawnObj(GameObject obj)
    {
        spawnObj = obj;
    }

    void Spawn()
    {
        isPaused = false;
        for(int i = 0; i < multiplier; i++)
        {
            Vector3 position = getRandomVector(center, radius);
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, -position);
            GameObject spawnedObj = Instantiate(spawnObj, position, rot) as GameObject;
            spawnedObj.transform.parent = transform;
            spawnedObj.transform.position = new Vector3(
                spawnedObj.transform.position.x,
                spawnedObj.transform.position.y,
                transform.position.z);
        }
    }

    public void StartSpawn()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    public void StopSpawn()
    {
        //Debug.Log ("Stopping");
        if (IsInvoking("Spawn"))
        {
            isPaused = true;
            CancelInvoke("Spawn");
        }
    }

    public void ResumeSpawn()
    {
        if (!IsInvoking("Spawn"))
        {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
        }
    }

    public abstract void SpawnFaster();

    Vector3 getRandomVector(Vector3 center, float radius)
    {
        float angle = Random.value * 360;
        Vector3 position;
        position.x = radius * Mathf.Sin(angle * Mathf.Deg2Rad) + center.x;
        position.y = radius * Mathf.Cos(angle * Mathf.Deg2Rad) + center.y;
        position.z = 0;
        return position;
    }

}
