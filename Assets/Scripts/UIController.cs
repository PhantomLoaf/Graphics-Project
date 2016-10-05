using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    public Text scoreText;
    public Text livesText;

    private int score;
 	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        score += (int)(100*Time.deltaTime);
        scoreText.text = "Score: " + score;
	}
}
