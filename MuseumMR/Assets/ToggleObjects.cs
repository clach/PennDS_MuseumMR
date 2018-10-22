using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjects : MonoBehaviour {

    public GameObject model1;
    public GameObject model2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnSelect()
    {
        Debug.Log("MESSAGE RECEIVED!");

        // toggle object views
        model1.SetActive(!model1.activeSelf);
        model2.SetActive(!model2.activeSelf);
        //this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}
