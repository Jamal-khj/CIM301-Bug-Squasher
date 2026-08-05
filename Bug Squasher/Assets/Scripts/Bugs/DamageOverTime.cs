using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class DamageOverTime : MonoBehaviour
{
    private PlayerHealth playerHealth;

    public float dotTimer;
    public float damageTimer;
    public int dotDamage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dotTimer += Time.deltaTime;
        
        // Deal damage over time as long as the bug is on the player
        if (dotTimer > damageTimer)
            {
                if (playerHealth != null)
                    {
                        // Deal damage to the player
                        playerHealth.TakeDamage(dotDamage);

                        dotTimer = 0.0f;

                    }
            }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Since bugs are prefab, we need this line to find the player component
            if (playerHealth == null)
            {
                playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            }

        }
    }
}