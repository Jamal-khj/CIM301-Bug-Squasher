using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int healAmount;
    public int damage;

    private PlayerHealth playerHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = FindAnyObjectByType<PlayerHealth>();
        health = maxHealth;
    }

    private void OnMouseDown()
    {
        health -= damage;
        if(health <= 0)
        {
            playerHealth.Heal(healAmount);
            Destroy(gameObject);
        }
    }
}