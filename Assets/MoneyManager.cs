using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _moneyUI;

    private int _currentMoney = 10;

    private int _turnIncome = 10;
    private int _goodCost = 30;

    public int CurrentMoney { get => _currentMoney; private set
        {
            _currentMoney = value;

            _moneyUI.text = _currentMoney + "$";
        }
    }

    public void AddMoney()
    {
        CurrentMoney += _turnIncome;
    }

    public void RemoveMoney()
    {
        CurrentMoney -= _goodCost;
    }
}
