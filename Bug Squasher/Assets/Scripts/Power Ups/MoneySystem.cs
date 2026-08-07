using UnityEngine;
using TMPro;

public class MoneySystem : MonoBehaviour
{
    public int money;
    public TextMeshProUGUI displayMoney;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        money = 0;
    }

    // Update is called once per frame
    void Update()
    {
        displayMoney.text = "Money: $" + money;
    }

    public void GainMoney(int amount)
    {
        money += amount;
    }

    public void DecreaseMoney(int amount)
    {
        money -= amount;
    }
}