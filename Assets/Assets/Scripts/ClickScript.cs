using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript : MonoBehaviour {

    public AudioClip clickSound;
    public AudioSource clickSource;

	// Use this for initialization
	void Awake() {
        DontDestroyOnLoad(this);
        clickSource.clip = clickSound;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playClick()
    {
        Debug.Log("Played");
        clickSource.Play();
    }
}
