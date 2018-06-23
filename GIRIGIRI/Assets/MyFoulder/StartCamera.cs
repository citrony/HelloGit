using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCameraScript : MonoBehaviour {
    [SerializeField] private GameObject MainCamera;
    [SerializeField] private GameObject StartCamera;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        { MainCamera.SetActive(!MainCamera.activeSelf);
          StartCamera.SetActive(!StartCamera.activeSelf);
        }

    }
}
