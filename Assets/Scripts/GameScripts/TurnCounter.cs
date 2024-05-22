using TMPro;
using UnityEngine;

public class TurnCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _turnUI;
    [SerializeField] private TMP_Text _turnUIOnNewTurn;
    [SerializeField] private NewTurnUI _newTurnUI;

    private int _maxAmountOfTurns = 20;

    private int _currentTurn = 0;

    public int CurrentTurn {  get => _currentTurn; }

    public void AddTurn()
    {
        _currentTurn++;

        _turnUI.text = $"{_currentTurn}/{_maxAmountOfTurns}";
        _turnUIOnNewTurn.text = $"{_currentTurn}/{_maxAmountOfTurns}";

        if(_currentTurn > 1)
            _newTurnUI.StartNewTurnAnimation();

        if (_currentTurn == _maxAmountOfTurns)
        {
            Debug.Log("Game should end");
            GameManager.Instance.ChangeGameState(GameState.Win);
        }
    }
}
