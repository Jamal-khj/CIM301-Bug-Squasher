using Unity.VisualScripting;
using UnityEngine;

public class HealButton : MonoBehaviour
{
    private PlayerHealth playerHealth;
    public int healAmount;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HealPlayer()
    {
        playerHealth.Heal(healAmount);
    }
}