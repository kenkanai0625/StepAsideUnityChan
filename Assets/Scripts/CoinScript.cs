﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {
    private GameObject maincamera;

    // Use this for initialization
    void Start () {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);

        this.maincamera = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
        //回転
        this.transform.Rotate(0, 3, 0);

        if (this.transform.position.z < maincamera.transform.position.z)

        {
            Destroy(this.gameObject);
        }
    }
}
