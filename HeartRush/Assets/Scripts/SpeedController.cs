using UnityEngine;
using Dreamteck.Forever;

public class HeartRateSpeedController : MonoBehaviour
{
    [Header("References")]
    public hyperateSocket heartRateSource;
    public LaneRunner laneRunner;

    [Header("Heart Rate Range")]
    public float minHeartRate = 60f;
    public float maxHeartRate = 160f;

    [Header("Speed Range")]
    public float minSpeed = 5f;
    public float maxSpeed = 20f;

    void Update()
    {
        if (heartRateSource == null || laneRunner == null) return;

        float hr = heartRateSource.currentHeartRate;

        // Clamp HR just in case
        hr = Mathf.Clamp(hr, minHeartRate, maxHeartRate);

        // Normalize HR to 0–1
        float t = Mathf.InverseLerp(minHeartRate, maxHeartRate, hr);

        // Convert to speed
        laneRunner.followSpeed = Mathf.Lerp(minSpeed, maxSpeed, t);
    }
}
