using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCubeEffect : MonoBehaviour
{

    public AudioClip se;
    Color a = new Color(116, 169, 260, 50);


    void OnCollisionExit(Collision collision)
    {
        GetComponent<Renderer>().material.color = a;
        GetComponent<AudioSource>().PlayOneShot(se);
        gameObject.tag = "Item";
    }

}
