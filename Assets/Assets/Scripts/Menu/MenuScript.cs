using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public int timesMoved;
    public Vector3 moveBackDistance;
    public Vector3 moveUpDistance;

	// Use this for initialization
	void Start () {
        timesMoved = 0;
        moveBackDistance = new Vector3(0, 0, .1f);
        moveUpDistance = new Vector3(0, 0, -.1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startDifficultyMenu()
    {
        Debug.Log("Pressed");
        GameObject.FindGameObjectWithTag("ClickSound").GetComponent<ClickScript>().playClick();
        SceneManager.LoadScene("Darts Difficulty Menu", LoadSceneMode.Single);
    }

    public void startStrikesEasy()
    {
        Debug.Log("Pressed");
        GameObject.FindGameObjectWithTag("ClickSound").GetComponent<ClickScript>().playClick();
        SceneManager.LoadScene("Darts 3 Strikes Easy", LoadSceneMode.Single);
    }

    public void startStrikesMedium()
    {
        Debug.Log("Pressed");
        GameObject.FindGameObjectWithTag("ClickSound").GetComponent<ClickScript>().playClick();
        SceneManager.LoadScene("Darts 3 Strikes Medium", LoadSceneMode.Single);
    }

    public void startStrikesHard()
    {
        Debug.Log("Pressed");
        GameObject.FindGameObjectWithTag("ClickSound").GetComponent<ClickScript>().playClick();
        SceneManager.LoadScene("Darts 3 Strikes Hard", LoadSceneMode.Single);
    }

    public void startEndless()
    {
        Debug.Log("Pressed");
        GameObject.FindGameObjectWithTag("ClickSound").GetComponent<ClickScript>().playClick();
        SceneManager.LoadScene("Darts Endless", LoadSceneMode.Single);
    }

    public void startDistance()
    {
        Debug.Log("Pressed");
        GameObject.FindGameObjectWithTag("ClickSound").GetComponent<ClickScript>().playClick();
        SceneManager.LoadScene("Darts Distance", LoadSceneMode.Single);
    }

    public void quit()
    {
        Debug.Log("Pressed");
        Application.Quit();
    }

    public void startMainMenu()
    {
        Debug.Log("Pressed");
        GameObject.FindGameObjectWithTag("ClickSound").GetComponent<ClickScript>().playClick();
        SceneManager.LoadScene("Darts Menu", LoadSceneMode.Single);
    }

    public void moveBack()
    {
        if(timesMoved < 20)
        {
            GameObject.FindGameObjectWithTag("Dartboard").transform.position += moveBackDistance;
            timesMoved++;
        }
    }

    public void moveUp()
    {
        if(timesMoved > 0)
        {
            GameObject.FindGameObjectWithTag("Dartboard").transform.position += moveUpDistance;
            timesMoved--;
        }
    }
}
