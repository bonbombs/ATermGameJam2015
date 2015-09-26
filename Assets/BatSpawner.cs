using UnityEngine;
using System.Collections;

public class BatSpawner : MonoBehaviour {

    public GameObject bat;
    public float radius;
    public float spawnTime = 3f;
	private bool isPaused = false;

    public GameObject ring;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBat", spawnTime, spawnTime);
	}


    void SpawnBat()
    {
		if (!isPaused) {
			float angle = getRandomAngle();
			float x = radius * Mathf.Cos(angle) + transform.position.x;
			float y = radius * Mathf.Sin(angle) + transform.position.y;
			Vector3 position = new Vector3(x, y, 0);
			
			GameObject newBat = Instantiate(bat) as GameObject;
			newBat.transform.position = position;
			newBat.transform.Rotate(position.normalized * -1);
			newBat.transform.parent = ring.transform;
		}
    }

    float getRandomAngle()
    {
        return Random.Range(0.0f, 360.0f);
    }

	public void StopBatSpawn(){
		//Debug.Log ("Stopping");
		isPaused = true;
	}

	public void ResumeBatSpawn(){
		isPaused = false;
	}

}
