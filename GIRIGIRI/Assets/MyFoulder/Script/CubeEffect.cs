using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEffect : MonoBehaviour {

    public AudioClip se;

    void OnCollisionStay(Collision col)
    {
        if (GetComponent<Renderer>().material.color != new Color(116, 169, 260, 50))
        {
        GetComponent<Renderer>().material.color = Color.black;
        }

    }
    void OnCollisionExit(Collision col)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Renderer>().material.color = new Color(116, 169, 260, 50);
            GetComponent<AudioSource>().PlayOneShot(se);
            gameObject.tag = "Item";
        }
  
    }

   

    
}
