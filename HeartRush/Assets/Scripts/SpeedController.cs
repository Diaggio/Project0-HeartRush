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

    void Start()
    {
        // Auto-link the LaneRunner on this GameObject
        laneRunner = GetComponent<LaneRunner>();
    }

    void Update()
        {
            float bpm = heartRateSource.currentHeartRate;

        if (bpm <= 80f)
        {
            laneRunner.followSpeed = 5f;
        }
        else if (bpm > 80f && bpm <= 120f)
        {
            // Linear increase from 5 to 10 between 80 and 120
            float t = (bpm - 80f) / 40f; // t goes from 0 to 1
            laneRunner.followSpeed = Mathf.Lerp(5f, 10f, t);
        }
        else
        {
            laneRunner.followSpeed = 10f;
        }
    }
}
