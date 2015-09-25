using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Rigidbody2D bullets;
    public float speed = 6;

	// Use this for initialization
	void Start () {
        //bullets = new Rigidbody2D();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D bone = Instantiate(bullets, transform.position, Quaternion.Euler(new Vector2(0, 0))) as Rigidbody2D;
            bone.velocity = new Vector2(0, speed);
        }
           
	}

}


