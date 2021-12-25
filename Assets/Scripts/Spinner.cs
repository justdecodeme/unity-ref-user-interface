using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour
{

    public float degreesPerSecond = 10;
    public float rotationTime = 2;

    float rotationStopTime = 0;

    void Update()
    {
        if (rotationStopTime > Time.time)
        {
            transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);
        }
    }

    public void StartSpinning()
    {
        rotationStopTime = Time.time + rotationTime;
    }

    public void StopSpinning()
    {
        rotationStopTime = 0;
    }

    public void SetRotationSpeed(float dps)
    {
        Debug.Log(dps);
        degreesPerSecond = dps;
    }

    public void SetRotationTime(float time)
    {
        rotationTime = time;
    }
}
