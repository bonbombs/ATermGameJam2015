using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    private Text speedText;
    private Text scoreText;
    private RectTransform health;
    public int score = 0;
	public Level[] Levels;
	private Level currentLevel;
	private RotateRing ring;
    private float maxHealth;

    // Use this for initialization
    void Start () {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        speedText = GameObject.Find("SpeedText").GetComponent<Text>();
        health = GameObject.Find("Health").GetComponent<RectTransform>();
        ring = GameObject.Find ("ring").GetComponent<RotateRing> ();
		currentLevel = Levels [0];
        //ring.UpdateLevel (currentLevel);

        maxHealth = health.sizeDelta.y;
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = score.ToString();
        speedText.text = "Speed: " + ring.speed.ToString() + "x";
	}

    public void UpdateHealth(float dmgTaken)
    {
        dmgTaken = (dmgTaken / 100) * maxHealth;
        health.sizeDelta = new Vector2(health.sizeDelta.x, maxHealth - dmgTaken);
    }

}
