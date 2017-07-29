using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

    Vector3 cameraPos;

	// Use this for initialization
	void Start () {
        cameraPos = Camera.main.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))

            Debug.Log("Recieving Mouse input");
    }
}
