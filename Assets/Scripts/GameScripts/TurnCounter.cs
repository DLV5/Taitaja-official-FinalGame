using System.Collections;
using TMPro;
using UnityEngine;

public class TurnCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _turnUI;
    [SerializeField] private TMP_Text _turnUIOnNewTurn;
    [SerializeField] private NewTurnUI _newTurnUI;

    private int _maxAmountOfTurns = 20;

    [SerializeField] private CivilizationObjectsSpawner _civilizationSpawner;

    private int _currentTurn = 0;

    public int CurrentTurn {  get => _currentTurn; }

    public void AddTurn()
    {
        _currentTurn++;

        _turnUI.text = $"{_currentTurn}/{_maxAmountOfTurns}";
        _turnUIOnNewTurn.text = $"{_currentTurn}/{_maxAmountOfTurns}";
        _civilizationSpawner.SpawnNextObject();

        StartCoroutine(SpawnWithDelay());

        if(_currentTurn > 1)
            _newTurnUI.StartNewTurnAnimation();

        if (_currentTurn == _maxAmountOfTurns)
        {
            Debug.Log("Game should end");
            GameManager.Instance.ChangeGameState(GameState.Win);
        }
    }

    private IEnumerator SpawnWithDelay()
    {
        yield return new WaitForSecondsRealtime(1f);
        _civilizationSpawner.SpawnNextObject();
    }
}
