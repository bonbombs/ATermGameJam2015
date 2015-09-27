using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    private ScoreCounter scoreCount;

	// Use this for initialization
	void Start () {
        scoreCount = FindObjectOfType<ScoreCounter>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Contains("BoundBox"))
        {
            Destroy(gameObject);
        }
        if (col.gameObject.name.Contains("bat"))
        {
            scoreCount.score++;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        if(col.gameObject.GetComponent<PowerUp>() != null)
        {
            Destroy(gameObject);
        }
    }
}
