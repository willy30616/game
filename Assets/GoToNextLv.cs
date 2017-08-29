using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToNextLv : MonoBehaviour {

    public void OnTriggerEnter(Collider other) {

        SceneManager.LoadScene("1234", LoadSceneMode.Single);

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
