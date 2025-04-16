using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

public class SnapTurningManager : MonoBehaviour
{
    [Header("Snap Turn Settings")]
    public SnapTurnProvider snapTurnProvider;

    [Header("UI Elements")]
    public Toggle snapTurnToggle;

    void Start()
    {
        if (snapTurnProvider == null)
        {
            Debug.LogWarning("SnapTurnProvider is not assigned!");
            return;
        }

        if (snapTurnToggle != null)
        {
            snapTurnToggle.isOn = snapTurnProvider.enabled;
            snapTurnToggle.onValueChanged.AddListener(SetSnapTurn);
        }
    }

    public void SetSnapTurn(bool isOn)
    {
        if (snapTurnProvider != null)
        {
            snapTurnProvider.enabled = isOn;
        }
    }
}