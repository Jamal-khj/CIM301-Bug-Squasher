using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class DamageOverTime : MonoBehaviour
{
    private PlayerHealth playerHealth;

    public int dotTimer;
    public int dotDamage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}