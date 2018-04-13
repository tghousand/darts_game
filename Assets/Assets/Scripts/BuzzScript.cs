using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzScript : MonoBehaviour {

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

    public void playBuzz()
    {
        Debug.Log("Played");
        clickSource.Play();
    }
}
