using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class LevelReloadManager : MonoBehaviour
{
    public Candidate CurrentCandidate {  get; set; }

    [SerializeField] private ElectionScreen _electionScreen;
    [SerializeField] private NewsScreen _newsScreen;

    [SerializeField] private GameObject _closedUntilNextTurnScreen;
    [SerializeField] private GameObject _reminderScreen;

    [SerializeField] private Image _background;

    [SerializeField] private TurnCounter _counter;

    private void Start()
    {
        UpdateADayForTheFirstTime();
    }

    public void UpdateADayForTheFirstTime()
    {
        Debug.LogWarning("New week started");

        //Get candidates
        _electionScreen.GetNewCandidates();

        _closedUntilNextTurnScreen.SetActive(false);
        _counter.AddTurn();
    }

    public void UpdateADay()
    {
        if (CurrentCandidate == null)
        {
            _reminderScreen.SetActive(true);

            Debug.LogWarning("You didn't select a candidate");
            return;
        }

        _closedUntilNextTurnScreen.SetActive(false);

        _counter.AddTurn();

        _electionScreen.GetNewCandidates();
        //Show news from the previous day
        _newsScreen.UpdateNews(CurrentCandidate);
        //Change background

        CurrentCandidate = null;
    }

    private void UpdateBackground()
    {
        _background.sprite = CurrentCandidate.RelatedBackGround;
    }
}
