using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DingScript : MonoBehaviour {

    public AudioClip clickSound;
    public AudioSource clickSource;

    // Use this for initialization
    void Awake()
    {
        clickSource.clip = clickSound;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playDing()
    {
        Debug.Log("Played");
        clickSource.Play();
    }
}
