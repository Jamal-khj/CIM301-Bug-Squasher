using UnityEngine;

public class DamageOnClick : MonoBehaviour
{
    private HealthSystem healthSystem;
    public int damage = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.tag == "Enemy")
            {
                healthSystem.TakeDamage(damage);
            }
        }
    }
}