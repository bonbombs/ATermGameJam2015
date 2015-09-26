using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

    private Text scoreText;
    public int score = 0;

    // Use this for initialization
    void Start () {
        scoreText = GameObject.Find("Score").GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = score.ToString();
	}
}
