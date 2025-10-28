using UnityEngine;

public class Timer : MonoBehaviour
{
    private float duration;    
    private float startTime;   
    private bool isRunning;    

    public void SetDuration(float time)
    {
        duration = time;
    }

    public void StartTimer()
    {
        startTime = Time.time;
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public float GetElapsedTime()
    {
        return Time.time - startTime;
    }

    public bool IsRunning()
    {
        return isRunning;
    }

    public bool IsFinished()
    {
        return isRunning && (Time.time - startTime >= duration);
    }
}
