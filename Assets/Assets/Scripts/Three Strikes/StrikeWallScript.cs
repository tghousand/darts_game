using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeWallScript : MonoBehaviour {

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
        if (other.gameObject.tag == "StrikeDart")
        {
            GameObject.FindGameObjectWithTag("BuzzSound").GetComponent<BuzzScript>().playBuzz();
            GameObject.FindGameObjectWithTag("StrikeDart").GetComponent<StrikeDartScript>().outOfBounds = true;
            GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>().SetMissText();
        }
    }
}
