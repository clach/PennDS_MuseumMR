using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class ManipulationHandler : MonoBehaviour, IManipulationHandler
{
    public GameObject model1;
    public GameObject model2;

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
