using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour {

    float rotSpeed = 20;

    void OnTrigger() {

        float rotX = Input.GetAxis("X") * rotSpeed * Mathf.Deg2Rad;
        float rotZ = Input.GetAxis("Z") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotX);

    }
}
