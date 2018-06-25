using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back2 : MonoBehaviour {

    public AudioClip se;
    Vector3 startPos; // 初期位置座標
    Transform player; // プレイヤー座標

    void Start()
    {
        player = GameObject.Find("Player").transform; // Playerという名前のオブジェクトを取得
        startPos = transform.position; // 初期位置を代入
    }

    // Use this for initialization
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            GetComponent<AudioSource>().PlayOneShot(se);
            player.transform.position = startPos; // 座標を指定
        }

    }

    
}
