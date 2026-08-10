using UnityEngine;

public class IncreaseBugsMaxHealth : MonoBehaviour
{
    public int increaseAmount;
    public float increaseTimer;
    public float timerLimit;

    public HealthSystem healthSystem;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthSystem = FindAnyObjectByType<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        increaseTimer += Time.deltaTime;

        if(increaseTimer >= timerLimit)
        {
            increaseTimer = 0;
            //HealthSystem.IncreaseMaxHealth(increaseAmount);
        }
    }
}