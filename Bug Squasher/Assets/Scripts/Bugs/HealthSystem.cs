using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth;
    public int health;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    void TakeDamage(int amount)
    {
        health -= amount;

        if(health <= 0)
        {
            // For the bugs
                // Destory Object
        }
    }
}