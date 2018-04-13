using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeDartBoardScript : MonoBehaviour {

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
            GameObject.FindGameObjectWithTag("DingSound").GetComponent<DingScript>().playDing();
            GameObject.FindGameObjectWithTag("StrikeDart").GetComponent<StrikeDartScript>().scored = true;
            GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>().SetScoreText();
        }
    }
}
