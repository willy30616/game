using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLv3 : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("12345", LoadSceneMode.Single);

    }
}
