using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacingBilboard : MonoBehaviour {

    private Transform mainCameraTransform;
	// Use this for initialization
	void Start () {
        mainCameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}

    private void Update()
    {
        transform.LookAt(mainCameraTransform);
    }
}
