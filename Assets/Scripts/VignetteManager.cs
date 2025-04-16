using UnityEngine;
using UnityEngine.UI;
public class VignetteManager : MonoBehaviour
{
    [Header("Vignette Mesh Root")]
    public GameObject vignetteObject; // Assign the 'TunnelingVignette' GameObject here

    [Header("UI Controls")]
    public Toggle vignetteToggle;
    public Slider intensitySlider;

    [Header("Scaling Settings")]
    public Vector3 minScale = Vector3.zero;       // No vignette
    public Vector3 maxScale = new Vector3(1, 1, 1); // Full screen effect

    void Start()
    {
        if (vignetteToggle != null)
        {
            vignetteToggle.onValueChanged.AddListener(SetVignetteActive);
            vignetteToggle.isOn = vignetteObject.activeSelf;
        }

        if (intensitySlider != null)
        {
            intensitySlider.onValueChanged.AddListener(SetVignetteIntensity);
            intensitySlider.value = 1f; // Default full intensity
        }
    }

    public void SetVignetteActive(bool isActive)
    {
        if (vignetteObject != null)
        {
            vignetteObject.SetActive(isActive);
        }
    }

    public void SetVignetteIntensity(float value)
    {
        if (vignetteObject != null)
        {
            vignetteObject.transform.localScale = Vector3.Lerp(minScale, maxScale, value);
        }
    }
}
