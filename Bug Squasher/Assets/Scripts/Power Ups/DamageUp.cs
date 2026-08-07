using UnityEngine;
using TMPro;

public class DamageUp : MonoBehaviour
{
    public int startingCost;
    public int currentCost;
    public int priceIncrease;
    public int amount;
    public TextMeshProUGUI displayCost;

    private MoneySystem moneySystem;
    private DamageOnClick damageOnClick;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCost = startingCost;
        moneySystem = FindAnyObjectByType<MoneySystem>();
        //damageOnClick = FindAnyObjectByType<DamageOnClick>();
    }

    // Update is called once per frame
    void Update()
    {
        displayCost.text = "$"+currentCost;
    }

    public void BuyDamageUp(int amount)
    {
        if (moneySystem.money >= currentCost)
        {
            //damageOnClick.IncreaseDamage(amount);
            moneySystem.DecreaseMoney(currentCost);
            currentCost = currentCost * priceIncrease;
        }
    }
}