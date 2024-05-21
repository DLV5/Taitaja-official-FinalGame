using TMPro;
using UnityEngine;

public class TurnCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _turnUI;

    [SerializeField] private int _maxAmountOfTurns = 30;

    private int _currentTurn = 0;

    public void AddTurn()
    {
        _currentTurn++;
        _turnUI.text = $"{_currentTurn}/{_maxAmountOfTurns}";
    }
}
