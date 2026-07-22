using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public int damage;
    //private HealthSystem healthSystem;
    
    private void OnMouseUp()
    {
        Destroy(gameObject);
        //healthSystem.TakeDamage(damage);
    }
}