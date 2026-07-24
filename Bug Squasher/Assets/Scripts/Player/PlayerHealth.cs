using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int health;
    public GameObject gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        gameOver.SetActive(false);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Damage Dealt");
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}