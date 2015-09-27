using UnityEngine;
using System.Collections;

public class RotateRing : MonoBehaviour {

    public string direction = "cw";         //direction of rotation
    public float speed = 10;                //speed of rotation

    private float maxSpeedCap = 3.0f;
    private float minSpeedCap = 0.25f;

	// Update is called once per frame
	void Update () {

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

    public void SpeedUp(float newSpeed)
    {
        if (speed < maxSpeedCap && speed > minSpeedCap)
        {
            speed += newSpeed;

            if(speed > 0.75)
            {
                BroadcastMessage("SpawnFaster", SendMessageOptions.DontRequireReceiver);
            }
        }
        else if(speed < minSpeedCap)
        {
            speed += 0.25f;
        }
        else if(speed > maxSpeedCap)
        {
            speed -= 0.5f;
        }
    }

    public void ChangeDirection(string newDirection)
    {
        direction = newDirection;
    }

}
