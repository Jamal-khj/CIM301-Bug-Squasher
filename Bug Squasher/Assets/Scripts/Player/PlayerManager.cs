using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int startingCost;
    public int currentCost;
    public int priceIncrease;
    public int amount;
    public TextMeshProUGUI displayCost;

    private MoneySystem moneySystem;

    public int playerAttackDamage;

    public GameObject currentBug;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCost = startingCost;
        moneySystem = FindAnyObjectByType<MoneySystem>();
    }

    // Update is called once per frame
    void Update()
    {
        displayCost.text = "$" + currentCost;
    }

    public void IncreaseDamage(int amount)
    {
        playerAttackDamage += amount;
    }

    public void BuyDamageUp(int amount)
    {
        if (moneySystem.money >= currentCost)
        {
            Debug.Log("Increase Damage");
            IncreaseDamage(amount);
            moneySystem.DecreaseMoney(currentCost);
            currentCost = currentCost * priceIncrease;
        }
    }
}