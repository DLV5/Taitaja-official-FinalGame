using UnityEngine;
using UnityEngine.UI;

public class LevelReloadManager : MonoBehaviour
{
    public Candidate CurrentCandidate {  get; set; }

    [SerializeField] private ElectionScreen _electionScreen;
    [SerializeField] private NewsScreen _newsScreen;

    [SerializeField] private GameObject _closedUntilNextTurnScreen;

    [SerializeField] private Image Background;

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
    }

    public void UpdateADay()
    {
        if (CurrentCandidate == null)
        {
            Debug.LogWarning("You didn't select a candidate");
            return;
        }

        _closedUntilNextTurnScreen.SetActive(false);

        _electionScreen.GetNewCandidates();
        //Show news from the previous day
        _newsScreen.UpdateNews(CurrentCandidate);
        //Change background

        CurrentCandidate = null;
    }

    private void UpdateBackground()
    {
        Background.sprite = CurrentCandidate.RelatedBackGround;
    }
}
