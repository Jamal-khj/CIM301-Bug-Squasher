using UnityEngine;
using TMPro;

public class KillCount : MonoBehaviour
{
    public int killCounter;
    public TextMeshProUGUI displayKillCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        killCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        displayKillCount.text = "" + killCounter;
    }

    public void KillCounter(int amount)
    {
        killCounter += amount;
    }
}