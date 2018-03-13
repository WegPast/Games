﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneBox : MonoBehaviour {

    private PinSetter pinSetter;

	// Use this for initialization
	void Start () {
        pinSetter = FindObjectOfType<PinSetter>();
	}

    private void OnTriggerExit(Collider other) {
        if (other.GetComponent<Ball>()) {
            pinSetter.SetBallLeftBox(true);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}