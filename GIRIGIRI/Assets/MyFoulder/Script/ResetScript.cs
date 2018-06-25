using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetScript : MonoBehaviour {
    private RectTransform hoge;
    private RectTransform hoge2;

    // Use this for initialization
    void Start () {
        hoge = GameObject.Find("CubeText").GetComponent<RectTransform>();
        hoge.localPosition = new Vector3(120, 50, 1); //動いた！
        hoge2 = GameObject.Find("Timer").GetComponent<RectTransform>();
        hoge2.localPosition = new Vector3(1000, 1, 1); //動いた！
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Escape))
        { int sceneIndex
                  = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            SceneManager.LoadScene("Title");
            
        }
    }
}
