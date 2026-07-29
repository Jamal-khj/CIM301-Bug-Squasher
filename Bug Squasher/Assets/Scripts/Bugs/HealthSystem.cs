using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    // Setting the max health and current health variable for the bugs
    public int maxHealth;
    public int health;

    public HealthBar healthBar;                 // Controls the Health Bar for the bugs

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;                     // Current health will match max health when object spawned
        healthBar.SetMaxHealth(maxHealth);      // Sets the Health Bar to max
    }

    public void TakeDamage(int damage)
    {
        health -= damage;                       // Current health will drop when damaged. Amount depends on an external factor
        healthBar.SetHealth(health);            // Sets the Health bar to reflect the current health

        // If current health reaches 0 or less, bugs will be destroyed
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}