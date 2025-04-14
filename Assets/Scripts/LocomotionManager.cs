using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;

public class LocomotionManager : MonoBehaviour
{
    public GameObject teleportRay; 
    public ContinuousMoveProvider continuousMove;
    public TeleportationProvider teleportationProvider;

    public void SetLocomotionMode(bool useTeleport)
    {
        if (useTeleport)
        {
            teleportRay.SetActive(true);
            continuousMove.enabled = false;
            teleportationProvider.enabled = true;
        }
        else
        {
            teleportRay.SetActive(false);
            continuousMove.enabled = true;
            teleportationProvider.enabled = false;
        }
    }
}
