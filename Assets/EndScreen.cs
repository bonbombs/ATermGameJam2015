using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Events;

public class EndScreen : MonoBehaviour {

    public Button replay;
    public Button exit;
    public Text score;

    private ScoreCounter scoreCounter;

	// Use this for initialization
	void Start () {
        scoreCounter = FindObjectOfType<ScoreCounter>();
        if(scoreCounter != null)
        {
            score.text = scoreCounter.score.ToString();
        }
        
        replay.onClick.AddListener(delegate
        {
            Destroy(scoreCounter);
            Application.LoadLevel("MainScreen");
        });

        exit.onClick.AddListener(delegate
        {
            Application.Quit();
        });
    }
       
}
