using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float dtheta = 1;
    public float theta = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (theta > 360)

        {
            dtheta = -1;
        }
        if (theta < 0)
        {
            dtheta = 1;
        }
        theta = theta + dtheta;
        transform.Rotate(Vector3.forward * Time.deltaTime * 50 * dtheta);

		
	}
}
