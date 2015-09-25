using UnityEngine;
using System.Collections;

public class Bats : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name.Contains("bat") && col.collider.name.Contains("bullet"))
        {
            Destroy(col.gameObject);
            Destroy(col.collider.gameObject);
        }
    }
}
