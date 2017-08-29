using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour {

    public GameObject sphere;
    public float countdown = -1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown < 0)
        {
            countdown = 0.2f;
            GameObject obj = (GameObject)Instantiate(sphere, transform.position, transform.rotation);
            obj.GetComponent<Rigidbody>().velocity = obj.transform.up * 10;
            Destroy(obj, 50f);

        }
	}
}
