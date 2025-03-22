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
        if(heartRateSource.currentHeartRate >= 65){
            laneRunner.followSpeed = 15f;
        }else{
            laneRunner.followSpeed=5f;
        }
    }
}
