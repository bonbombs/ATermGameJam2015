using UnityEngine;
using System.Collections;

public class RotateRing : MonoBehaviour {

    public string direction = "cw";         //direction of rotation
    public float speed = 10;                //speed of rotation
	public int batCount = 0;
	private int maxBats;

	// Update is called once per frame
	void Update () {
		batCount = transform.childCount;	//exclude spawner itself
		if (batCount >= maxBats) {
			Debug.Log("Max bats achieved");
			BroadcastMessage ("StopBatSpawn", SendMessageOptions.DontRequireReceiver);
		} else {
			BroadcastMessage ("ResumeBatSpawn", SendMessageOptions.DontRequireReceiver);
		}

        switch (direction)
        {
            case "cw":
                transform.Rotate(Vector3.forward * speed);
                break;
            case "ccw":
                transform.Rotate(Vector3.forward * -1 * speed);
                break;
        }
        
	}

	public void UpdateLevel(Level lv){
		direction = lv.Direction;
		speed = lv.Speed;
		maxBats = lv.maxBats;
	}
}
