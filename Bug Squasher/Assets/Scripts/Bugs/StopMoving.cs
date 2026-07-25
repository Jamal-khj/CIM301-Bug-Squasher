using UnityEngine;

public class StopMoving : MonoBehaviour
{
    //private BugsMovement bugsMovement;
    //private SineMovement sineMovement;
    public Behaviour bugsMovement;
    
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
            bugsMovement.enabled = false;
        }
    }
}