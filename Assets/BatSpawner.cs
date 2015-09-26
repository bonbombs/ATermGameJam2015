using UnityEngine;
using System.Collections;

public class BatSpawner : MonoBehaviour {

    public GameObject bat;
    public float radius;
    public float spawnTime = 3f;

    public GameObject ring;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBat", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {

	}

    void SpawnBat()
    {
        GameObject newBat = Instantiate(bat);
        newBat.transform.parent = ring.transform;
        float angle = getRandomAngle();
        float x = radius * Mathf.Cos(angle) + transform.position.x;
        float y = radius * Mathf.Sin(angle) + transform.position.y;
        Vector2 vector = new Vector2(x, y);

        newBat.transform.position = vector;
    }

    float getRandomAngle()
    {
        return Random.Range(0.0F, 360.0F);
    }
}
