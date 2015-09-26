using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

    private Text scoreText;
    public int score = 0;
	public Level[] Levels;
	private Level currentLevel;
	private RotateRing ring;

    // Use this for initialization
    void Start () {
        scoreText = GameObject.Find("Score").GetComponentInChildren<Text>();
		ring = GameObject.Find ("ring").GetComponent<RotateRing> ();
		currentLevel = Levels [0];
		ring.UpdateLevel (currentLevel);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = score.ToString();
	}

}
