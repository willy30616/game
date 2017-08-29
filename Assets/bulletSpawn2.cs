using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawn2 : MonoBehaviour {

    public GameObject bulee1;
    public GameObject bulletspawn2;

    float countdown = -1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        countdown = countdown - Time.deltaTime;
        {
            if (countdown < 0)
                countdown = 1f;
            GameObject obj = (GameObject)Instantiate(bulee1, bulletspawn2.transform.position,
                bulletspawn2.transform.rotation);
            obj.GetComponent<Rigidbody>().velocity = transform.forward * 0.5f;
            Destroy(obj, 1f);
        }
		
	}
}
