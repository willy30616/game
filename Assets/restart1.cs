using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart1 : MonoBehaviour {


    public void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("123", LoadSceneMode.Single);
    }
    // Use this for initialization


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
