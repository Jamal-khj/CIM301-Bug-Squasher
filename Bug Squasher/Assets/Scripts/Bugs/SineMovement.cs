using UnityEngine;

public class SineMovement : MonoBehaviour
{
    float sinCenterX;

    // Amplitude: Distance between side to side wave
    public float amplitude;

    // Frequency: How often does it flatuate between the highest and lowest value of the wave
    public float frequency;
    
    // Variable to invert the sine movement
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

    // Control sine wave here
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.y * frequency) * amplitude;

        if (inverted)
        {
            sin *= -1;
        }

        pos.x = sinCenterX + sin;

        transform.position = pos;
    }
}