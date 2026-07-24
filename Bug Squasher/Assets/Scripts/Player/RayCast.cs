using Unity.VisualScripting;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    Camera cam;
    public LayerMask mask;
    private HealthSystem healthSystem;
    public int damage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = cam.ScreenToWorldPoint(mousePos);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, mask))
            {
                Debug.Log(hit.transform.name);

                // SOMETHING WRONG DOWN HERE <---------------------
                //if (hit.collider == null)
                //{
                //    healthSystem.TakeDamage(damage);
                //}
            }

            // Provided by Anna
            //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, mask))
            //{
            //    healthSystem.TakeDamage(damage);
            //}
        }
    }
}