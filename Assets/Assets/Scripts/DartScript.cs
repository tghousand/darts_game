using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartScript : MonoBehaviour {

    public bool outOfBounds;
    public bool scored;


	// Use this for initialization
	void Start () {
        outOfBounds = false;
        scored = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(outOfBounds || scored)
        {
            GameObject newDart = Instantiate(Resources.Load("Dart")) as GameObject;
            Destroy(gameObject);
        }
	}
}
