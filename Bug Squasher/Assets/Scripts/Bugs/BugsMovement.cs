using UnityEngine;

public class BugsMovement : MonoBehaviour
{
    public float speed;

    float sinCenterX;

    // Amplitude: Distance between side to side wave
    // Frequency: How often does it flatuate between the highest and lowest value of the wave
    // Invert: Inverts the sine movement when enabled
    public float amplitude;
    public float frequency;
    public bool inverted = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sinCenterX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.y -= speed * Time.fixedDeltaTime;
        transform.position = pos;


        float sin = Mathf.Sin(pos.y * frequency) * amplitude;

        if (inverted)
        {
            sin *= -1;
        }

        pos.x = sinCenterX + sin;
        transform.position = pos;
    }
}