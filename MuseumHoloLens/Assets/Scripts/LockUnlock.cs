using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockUnlock : MonoBehaviour
{

    public GameObject objectToLock;
    public GameObject imageTarget;
    public Button lockUnlockButton;

    private bool locked = false;

    public void LockUnlockObject()
    {
        if (locked)
        {
            objectToLock.transform.parent = imageTarget.transform;
            lockUnlockButton.GetComponentInChildren<Text>().text = "Lock";
            locked = false;
        }
        else
        {
            objectToLock.transform.parent = null;
            lockUnlockButton.GetComponentInChildren<Text>().text = "Unlock";
            locked = true;
        }
    }
}