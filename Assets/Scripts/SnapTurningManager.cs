using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

public class SnapTurningManager : MonoBehaviour
{
    public SnapTurnProvider snapTurnProvider;

    public void SetSnapTurn(bool isOn)
    {
        snapTurnProvider.enabled = isOn;
    }
}