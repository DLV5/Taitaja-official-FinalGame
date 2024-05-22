using UnityEngine;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private Stats _stats;
    [SerializeField] private MoneyManager _moneyManager;
    [SerializeField] private int _cost = 30;

    public void BuyFood()
    {
        if(_cost <= _moneyManager.CurrentMoney)
        {
            _moneyManager.RemoveMoney();
            _stats.Hunger += 1;
        }
    }
    
    public void BuyWater()
    {
        if(_cost <= _moneyManager.CurrentMoney)
        {
            _moneyManager.RemoveMoney();
            _stats.Water += 1;
        }
    }
    
    public void BuyHeal()
    {
        if(_cost <= _moneyManager.CurrentMoney)
        {
            _moneyManager.RemoveMoney();
            _stats.Health += 1;
        }
    }
}
