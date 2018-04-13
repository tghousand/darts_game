using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDartScript : MonoBehaviour {

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
            if (GameObject.FindGameObjectWithTag("UI").GetComponent<DistanceUIScript>().misses == 1)
            {
                Destroy(gameObject);
                GameObject.FindGameObjectWithTag("UI").GetComponent<DistanceUIScript>().setGameOver();
                GameObject.FindGameObjectWithTag("UI").GetComponent<DistanceUIScript>().setDistance();
            }
            else
            {
                GameObject newDart = Instantiate(Resources.Load("DistanceDart")) as GameObject;
                Destroy(gameObject);
            }

        }
    }
}
