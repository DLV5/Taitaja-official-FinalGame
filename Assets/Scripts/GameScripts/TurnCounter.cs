using TMPro;
using UnityEngine;

public class TurnCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _turnUI;

    [SerializeField] private int _maxAmountOfTurns = 30;

    [SerializeField] private CivilizationObjectsSpawner _civilizationSpawner;

    private int _currentTurn = 0;

    public int CurrentTurn {  get => _currentTurn; }

    public void AddTurn()
    {
        _currentTurn++;
        _turnUI.text = $"{_currentTurn}/{_maxAmountOfTurns}";
        _civilizationSpawner.SpawnNextObject();

        if (_currentTurn == _maxAmountOfTurns)
        {
            GameManager.Instance.ChangeGameState(GameState.Win);
        }
    }
}
