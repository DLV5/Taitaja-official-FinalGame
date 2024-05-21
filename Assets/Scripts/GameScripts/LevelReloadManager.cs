using UnityEngine;
using UnityEngine.UI;

public class LevelReloadManager : MonoBehaviour
{
    public Candidate CurrentCandidate {  get; set; }

    [SerializeField] private ElectionScreen _electionScreen;
    [SerializeField] private NewsScreen _newsScreen;

    [SerializeField] private Image Background;

    private int _scienceCounter = 0;

    private void Start()
    {
        UpdateADayForTheFirstTime();
    }

    public void UpdateADayForTheFirstTime()
    {
        Debug.LogWarning("New week started");

        //Get candidates
        _electionScreen.GetNewCandidates();
    }

    public void UpdateADay()
    {
        if (CurrentCandidate == null)
        {
            Debug.LogWarning("You didn't select a candidate");
            return;
        }

        if (CurrentCandidate.Trait == Trait.Positive)
        {
            _scienceCounter++;
        }

        //Get candidates
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
