/* using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    [Header("Reference to your heart rate script")]
    public hyperateSocket heartRateSource;

    [Header("Image that fills the bar")]
    public Image fillImage;

    [Header("Heart rate range for fill")]
    public float minHeartRate = 60f;
    public float maxHeartRate = 160f;

    void Update()
    {
        if (heartRateSource == null || fillImage == null) return;

        //float bpm = heartRateSource.currentHeartRate;
        float normalized = Mathf.InverseLerp(minHeartRate, maxHeartRate, bpm);
        fillImage.fillAmount = normalized;
    }
}
 */