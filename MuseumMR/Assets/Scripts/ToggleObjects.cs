using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjects : MonoBehaviour {

    public GameObject model1;
    public GameObject model2;

    public void OnSelect()
    {
        // toggle object views
        model1.SetActive(!model1.activeSelf);
        model2.SetActive(!model2.activeSelf);
    }
}
