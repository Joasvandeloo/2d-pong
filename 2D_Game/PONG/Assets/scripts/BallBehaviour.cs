using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private int ballSpeed = 5;
    private float direction;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Add <Rigidbody2D> here!
        
        // Get a random y value between -1 and 1
        float randomY = Random.Range(-1f, 1f);
        
        // Create direction vector
        Vector2 directionVector = new Vector2(1f, randomY);
        
        // Normalize the vector
        directionVector.Normalize();
        
        // Set velocity
        rb.linearVelocity = ballSpeed * directionVector;
    }

    void Update()
    {
        
    }
}