using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Rigidbody2D bullets;
    public int bulletNum = 1;
    public int maxBullets = 12;
    public float speed = 6;
    public float waitTime = 1;        //In seconds

    private bool rotateEnabled = false;
	private static float scaleSize = 0.1f;
	private Vector3 scaleVector = new Vector3 (scaleSize, scaleSize, scaleSize);

	// Use this for initialization
	void Start () {
        //bullets = new Rigidbody2D();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (rotateEnabled)
        {
            transform.Rotate(Vector3.forward * 3);
        }   
    }
	void OnMouseDown () {
		transform.localScale -= scaleVector;
        int rotateAngle = 360 / bulletNum;
        int currentAngle = 0;
        for(int i = 0; i <= bulletNum; i++)
        {
            Rigidbody2D bone = Instantiate(bullets, transform.position, Quaternion.identity) as Rigidbody2D;
            //Vector2 vector = new Vector2(0, speed);
            Vector3 v = rotateVector(currentAngle);
            bone.velocity = v;
            currentAngle += rotateAngle;
        }
        
        Delay();
    }

	void OnMouseUp(){
		transform.localScale += scaleVector;
	}

    Vector3 rotateVector(float angle)
    {
        Vector3 vector = transform.up;
        vector.x = speed * Mathf.Sin(angle * Mathf.Deg2Rad);
        vector.y = speed * Mathf.Cos(angle * Mathf.Deg2Rad);
        return vector;
    }

    public void toggleRotate()
    {
        rotateEnabled = !rotateEnabled;
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


