using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dart")
        {
            GameObject.FindGameObjectWithTag("BuzzSound").GetComponent<BuzzScript>().playBuzz();
            GameObject.FindGameObjectWithTag("Dart").GetComponent<DartScript>().outOfBounds = true;
            GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>().SetMissText();
        }
    }
}
