using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int health;
    public GameObject gameOver;

    public HealthBar healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        gameOver.SetActive(false);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        healthBar.SetHealth(health);
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Heal(int healAmount)
    {
        health += healAmount;
        healthBar.SetHealth(health);
        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }
    public void IncreaseMaxHealth(int amount)
    {
        maxHealth += amount;
        health += amount;
        healthBar.SetHealth(health);
    }
}