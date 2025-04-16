using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;

public class LocomotionManager : MonoBehaviour
{
    public GameObject teleportRay;
    public ContinuousMoveProvider continuousMove;
    public TeleportationProvider teleportationProvider;

    public Button freeMoveButton;
    public Button teleportButton;

    public Color activeColor = Color.green;
    public Color inactiveColor = Color.white;

    public void SetLocomotionMode(bool useTeleport)
    {
        if (useTeleport)
        {
            teleportRay.SetActive(true);
            continuousMove.enabled = false;
            teleportationProvider.enabled = true;

            teleportButton.image.color = activeColor;
            freeMoveButton.image.color = inactiveColor;
        }
        else
        {
            teleportRay.SetActive(false);
            continuousMove.enabled = true;
            teleportationProvider.enabled = false;

            freeMoveButton.image.color = activeColor;
            teleportButton.image.color = inactiveColor;
        }
    }
}
