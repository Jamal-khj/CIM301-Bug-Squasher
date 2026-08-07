using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage;
    private PlayerHealth playerHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            // Since bugs are prefab, we need this line to find the player component
            if (playerHealth == null)
            {
                playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            }

            // Deal damage to the player
            // playerHealth.TakeDamage(damage);
        }
    }
}