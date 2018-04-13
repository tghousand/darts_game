using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Text scoreText;
    public Text missText;
    public Text gameOverText;
    public int score;
    public int misses;

	// Use this for initialization
	void Start () {
        score = 0;
        misses = 0;
        scoreText.alignment = TextAnchor.LowerLeft;
        missText.alignment = TextAnchor.LowerLeft;
        scoreText.text = "Score: " + score.ToString();
        missText.text = "Misses: " + misses.ToString();
        gameOverText.text = "";
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetScoreText()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void SetMissText()
    {
        misses++;
        missText.text = "Misses: " + misses.ToString();
    }

    public void setGameOver()
    {
        gameOverText.text = "GAME OVER";
    }
}
