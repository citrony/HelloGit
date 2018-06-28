using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour {

    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("unitychan_GIRIGIRI");	
	}

    public void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("unitychan_GIRIGIRI");
        }
    }
}
