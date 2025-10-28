using UnityEngine;

public class Scripts : MonoBehaviour
{
    private int countBounces = 0;
    private int maxBounces = 20;
    // private float timer = 0.0f;

    void Start()
    {
        Vector3 position = transform.position;
        position.x = 2;
        transform.position = position;

        int scaleFactor = 2;
        transform.localScale *= scaleFactor;

        // Debug.Log("the first script");

        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();

        if (rb2d != null)
        {
            float magnitude = Random.Range(3f, 5f);
            float angle = Random.Range(0f, 2f * Mathf.PI);

            float x = magnitude * Mathf.Cos(angle);
            float y = magnitude * Mathf.Sin(angle);

            Vector2 randomForce = new Vector2(x, y);
            rb2d.AddForce(randomForce, ForceMode2D.Impulse);

            Debug.Log($"Applied random force. Magnitude: {magnitude:F2}, Direction: {angle:F2} radians.");
        }
        else
        {
            Debug.LogError("Rigidbody2D component missing! Cannot apply random force.");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        countBounces++;

        // Debug.Log("bang");
        Debug.Log("Collision Count: " + countBounces);
        
        if (countBounces >= maxBounces)
        {
            Debug.Log("Object destroyed after 20 collisions");
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // timer += Time.deltaTime;

        // if (timer > 2.0f)
        // {
        //     Debug.Log("The 2.0 - second timer has ended");
        //     timer = 0.0f;
        // }
    }
}
