using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yell : MonoBehaviour {

    public AudioClip clip;

    public void OnTriggerEnter(Collider other)
        {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
