using UnityEngine;

public class BallDestroyer : MonoBehaviour
{
    private Timer timer;

    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.SetDuration(10f);   // Set 10 seconds
        timer.StartTimer();       // Start counting
    }

    void Update()
    {
        if (timer.IsFinished())
        {
            Debug.Log("BallDestroyer: Timer finished, destroying ball.");
            Destroy(gameObject);
        }
    }
}
