using UnityEngine;

public class TestTimer : MonoBehaviour
{
    private Timer timer;

    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.SetDuration(3f);  
        timer.StartTimer();
        Debug.Log("Timer started!");
    }

    void Update()
    {
        if (timer.IsFinished())
        {
            // Debug.Log("Timer finished after 3 seconds!");

            // timer.StartTimer();
            // Debug.Log("Timer restarted!");
        }
    }
}