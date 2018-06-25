using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundCounter : MonoBehaviour {
    public Text text;
    
    // Use this for initialization
    void Start () {
        text.text = "Cube";
		
	}
	
	// Update is called once per frame
	void Update () {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        text.text = count.ToString() + "/30";
	}
}
