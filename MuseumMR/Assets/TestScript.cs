using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {
    int count = 0;
	// Use this for initialization
	void Start () {
        Debug.Log("I just want to see vuforia is working");
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("I'm running " + count + "!");
        count++;
    }
}
