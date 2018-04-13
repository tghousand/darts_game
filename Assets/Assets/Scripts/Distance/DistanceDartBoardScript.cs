using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDartBoardScript : MonoBehaviour {

    public int timesMoved;
    public Vector3 moveDistance;

    // Use this for initialization
    void Start()
    {
        timesMoved = 0;
        moveDistance = new Vector3(0, 0, .1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DistanceDart")
        {
            if(timesMoved < 20)
            {
                GameObject.FindGameObjectWithTag("Dartboard").transform.position += moveDistance;
                timesMoved++;
            }
            GameObject.FindGameObjectWithTag("DingSound").GetComponent<DingScript>().playDing();
            GameObject.FindGameObjectWithTag("DistanceDart").GetComponent<DistanceDartScript>().scored = true;
            GameObject.FindGameObjectWithTag("UI").GetComponent<DistanceUIScript>().SetScoreText();
            GameObject.FindGameObjectWithTag("UI").GetComponent<DistanceUIScript>().distance++;
        }
    }
}
