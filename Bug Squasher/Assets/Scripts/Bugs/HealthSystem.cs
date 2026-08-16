using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    // Setting the max health, current health variable and HP Bar for the bugs
    public int maxHealth;
    public int health;
    public HealthBar healthBar;
    //===================================================

    // Kill counter setup
    public int countKill;
    public KillCount killCount;
    //===================================================

    // A variable for the money dropped after squashing a bug
    public int moneyDrop;
    private MoneySystem moneySystem;
    //===================================================

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;                     // Current health will match max health when object spawned
        healthBar.SetMaxHealth(maxHealth);      // Sets the Health Bar to max
        moneySystem = FindAnyObjectByType<MoneySystem>();

        killCount = FindAnyObjectByType<KillCount>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;                       // Current health will drop when damaged. Amount depends on an external factor
        healthBar.SetHealth(health);            // Sets the Health bar to reflect the current health

        // If current health reaches 0 or less, bugs will be destroyed
        if (health <= 0)
        {
            Destroy(gameObject);

            moneySystem.GainMoney(moneyDrop);
            killCount.KillCounter(countKill);
            Debug.Log("count up");
        }
    }

    public void IncreaseMaxHealth(int amountIncrease)
    {
        maxHealth += amountIncrease;
    }
}