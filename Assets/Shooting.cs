using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Rigidbody2D bullets;
    public float speed = 6;
    public float waitTime = 1;        //In seconds
    private bool isShooting = false;

	// Use this for initialization
	void Start () {
        //bullets = new Rigidbody2D();
	}
	
	// Update is called once per frame
    void Update()
    {
        
    }
	void OnMouseDown () {
        Rigidbody2D bone = Instantiate(bullets, transform.position, Quaternion.Euler(new Vector2(0, 0))) as Rigidbody2D;
        bone.velocity = new Vector2(0, speed);
        Delay();
    }

    void Delay()
    {
        StartCoroutine(Reactivate());
    }

    IEnumerator Reactivate()
    {
        yield return new WaitForSeconds(waitTime);
    }

}


