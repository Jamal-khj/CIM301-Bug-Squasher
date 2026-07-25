using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    // Setting the max health and current health variable for the bugs
    public int maxHealth;
    public int health;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Current health will match max health when object spawned
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        // Current health will drop when damaged. Amount depends on an external factor
        health -= damage;

        // If current health reaches 0 or less, bugs will be destroyed
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}