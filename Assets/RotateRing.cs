using UnityEngine;
using System.Collections;

public class RotateRing : MonoBehaviour {

    public string direction = "cw";         //direction of rotation
    public float speed = 10;                //speed of rotation

	// Use this for initialization
	void Start () {

	}
	
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
}
