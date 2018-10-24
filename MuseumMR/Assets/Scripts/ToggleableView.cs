using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class ToggleableView : MonoBehaviour, IInputClickHandler, IInputHandler
{
    public GameObject model1;
    public GameObject model2;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        // toggle object views
        model1.SetActive(!model1.activeSelf);
        model2.SetActive(!model2.activeSelf);
    }

    public void OnInputDown(InputEventData eventData)
    { }

    public void OnInputUp(InputEventData eventData)
    { }
}