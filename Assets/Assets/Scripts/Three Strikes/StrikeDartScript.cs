using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeDartScript : MonoBehaviour {

    public bool outOfBounds;
    public bool scored;


    // Use this for initialization
    void Start()
    {
        outOfBounds = false;
        scored = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (outOfBounds || scored)
        {
            if(GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>().misses == 3)
            {
                Destroy(gameObject);
                GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>().setGameOver();
            }
            else
            {
                GameObject newDart = Instantiate(Resources.Load("StrikeDart")) as GameObject;
                Destroy(gameObject);
            }

        }
    }
}
