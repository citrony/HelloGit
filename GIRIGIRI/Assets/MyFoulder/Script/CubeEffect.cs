using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEffect : MonoBehaviour {

    public AudioClip se;
    Color a = new Color(116, 169, 260, 50);

    void OnCollisionStay(Collision col)
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
    void OnCollisionExit(Collision col)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Renderer>().material.color = a;
            GetComponent<AudioSource>().PlayOneShot(se);
            gameObject.tag = "Item";
        }
  
    }

   

    
}
