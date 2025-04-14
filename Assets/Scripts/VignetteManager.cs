using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VignetteManager : MonoBehaviour
{
    [Header("Post-Processing")]
    public Volume postProcessingVolume;
    public float movementThreshold = 0.1f;

    [Header("UI Elements")]
    public Slider intensitySlider;
    public Slider smoothnessSlider;
    public Toggle vignetteToggle;
    public GameObject vignetteSettingsPanel;

    private Vignette vignette;

    void Start()
    {
        if (postProcessingVolume.profile.TryGet(out vignette))
        {
            // Initialize sliders and toggle
            intensitySlider.value = vignette.intensity.value;
            smoothnessSlider.value = vignette.smoothness.value;
            vignetteToggle.isOn = vignette.active;

            // Hook up UI events
            vignetteToggle.onValueChanged.AddListener(ToggleVignette);
            intensitySlider.onValueChanged.AddListener(UpdateIntensity);
            smoothnessSlider.onValueChanged.AddListener(UpdateSmoothness);

            // Show/hide settings panel
            vignetteSettingsPanel.SetActive(vignette.active);
        }
        else
        {
            Debug.LogWarning("Vignette not found on post-processing volume!");
        }
    }

    public void UpdateIntensity(float value)
    {
        if (vignette != null && vignette.active)
            vignette.intensity.value = value;
    }

    public void UpdateSmoothness(float value)
    {
        if (vignette != null && vignette.active)
            vignette.smoothness.value = value;
    }

    public void ToggleVignette(bool isOn)
    {
        if (vignette != null)
        {
            vignette.active = isOn;
            vignetteSettingsPanel.SetActive(isOn);
        }
    }
}
