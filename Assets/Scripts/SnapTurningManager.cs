using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

public class SnapTurningManager : MonoBehaviour
{
    // Reference to turning providers
    public ContinuousTurnProvider continuousTurnProvider;
    public SnapTurnProvider snapTurnProvider;

    // UI Buttons
    public Button continuousTurnButton;
    public Button snapTurnButton;

    // Colors for active/inactive button states
    public Color activeColor = Color.green;
    public Color inactiveColor = Color.white;

    // To track current turning mode
    private bool isContinuousTurnMode = false;

    // Toggle between continuous and snap turning
    public void ToggleContinuousTurnMode(bool isActive)
    {
        isContinuousTurnMode = isActive;
        UpdateTurningMode(isContinuousTurnMode);
    }

    // Updates the turning mode based on the flag
    private void UpdateTurningMode(bool isContinuous)
    {
        if (isContinuous)
        {
            // Enable continuous turning and disable snap turning
            continuousTurnProvider.enabled = true;
            snapTurnProvider.enabled = false;

            // Update button colors
            continuousTurnButton.image.color = activeColor;
            snapTurnButton.image.color = inactiveColor;
        }
        else
        {
            // Enable snap turning and disable continuous turning
            continuousTurnProvider.enabled = false;
            snapTurnProvider.enabled = true;

            // Update button colors
            snapTurnButton.image.color = activeColor;
            continuousTurnButton.image.color = inactiveColor;
        }
    }
}