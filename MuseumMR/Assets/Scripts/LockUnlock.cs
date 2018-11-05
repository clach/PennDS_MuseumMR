using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockUnlock : MonoBehaviour {

    public GameObject model;
    public GameObject imageTarget;

    private bool locked = false;

    public void LockUnlockModel()
    {
        if (locked) {
            model.transform.parent = imageTarget.transform;
            GameObject.Find("LockUnlockButton").GetComponentInChildren<Text>().text = "Lock";
            locked = false;
        }
        else
        {
            model.transform.parent = null;
            GameObject.Find("LockUnlockButton").GetComponentInChildren<Text>().text = "Unlock";
            locked = true;
        }
    }
}
