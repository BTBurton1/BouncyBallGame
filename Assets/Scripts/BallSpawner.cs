using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float xOffset = 11f;
    [SerializeField] private float yOffset = 5f;

    private Timer spawnTimer;
    private const float MinSpawnDelay = 2f;
    private const float MaxSpawnDelay = 4f;

    void Start()
    {
        spawnTimer = gameObject.AddComponent<Timer>();
        SetAndRunNewTimer();
    }

    void Update()
    {
        if (spawnTimer.IsFinished())
    {
        // Only spawn if no balls currently exist
        if (GameObject.FindGameObjectsWithTag("Ball").Length == 0)
        {
            Debug.Log("SPAWNER: Spawning a new ball.");
            SpawnBall();
        }

        SetAndRunNewTimer();
    }
    }

    private void SetAndRunNewTimer()
    {
        float randomDelay = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.SetDuration(randomDelay);
        spawnTimer.StartTimer();
    }

    private void SpawnBall()
    {
        float randomX = Random.Range(transform.position.x - xOffset, transform.position.x + xOffset);
        float randomY = Random.Range(transform.position.y - yOffset, transform.position.y + yOffset);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }
}
