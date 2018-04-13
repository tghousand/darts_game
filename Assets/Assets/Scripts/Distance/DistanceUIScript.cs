using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceUIScript : MonoBehaviour {

    public Text scoreText;
    public Text missText;
    public Text gameOverText;
    public Text distanceText;
    public int score;
    public int misses;
    public int distance;

    // Use this for initialization
    void Start()
    {
        score = 0;
        misses = 0;
        distance = 5;
        scoreText.alignment = TextAnchor.LowerLeft;
        missText.alignment = TextAnchor.LowerLeft;
        scoreText.text = "Score: " + score.ToString();
        missText.text = "Misses: " + misses.ToString();
        distanceText.text = "";
        gameOverText.text = "";

    }

    // Update is called once per frame
    void Update()
    {

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

    public void setDistance()
    {
        distanceText.text = "Distance: " + distance.ToString() + " Feet";
    }
}
