using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceWallScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DistanceDart")
        {
            GameObject.FindGameObjectWithTag("BuzzSound").GetComponent<BuzzScript>().playBuzz();
            GameObject.FindGameObjectWithTag("DistanceDart").GetComponent<DistanceDartScript>().outOfBounds = true;
            GameObject.FindGameObjectWithTag("UI").GetComponent<DistanceUIScript>().SetMissText();
        }
    }
}
