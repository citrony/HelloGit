using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text timerText;

    public float totalTime;
    int seconds;

    [SerializeField] private GameObject MainCamera;
    [SerializeField] private GameObject FinishCamera;

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = "Time:" + seconds.ToString();

        if (totalTime > 300)
        {
            timerText.text = "Time:300";
        }


        if (totalTime < 0.0f)
        {
            MainCamera.SetActive(!MainCamera.activeSelf);
            FinishCamera.SetActive(!FinishCamera.activeSelf);
           
        }
    }

   
}
