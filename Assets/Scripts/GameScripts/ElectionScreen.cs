using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ElectionScreen : MonoBehaviour
{
    [Serializable]
    public class CandidateUI
    {
        [field: SerializeField] public Image Photo { get; set; }
        [field: SerializeField] public TMP_Text Name { get; set; }
        [field: SerializeField] public TMP_Text Description { get; set; }
        [field: SerializeField] public TMP_Text Promise { get; set; }
        [field: SerializeField] public Button VoteButton { get; set; }
    }

    [SerializeField] private CandidatesData _candidatesData;

    [SerializeField] private CandidateUI _firstCandidateUI;
    [SerializeField] private CandidateUI _secondCandidateUI;

    [SerializeField] private LevelReloadManager _manager;

    private CandidatesData _candidatesDataCopy;

    private void Awake()
    {
        if (_candidatesDataCopy == null)
        {
            _candidatesDataCopy = Instantiate(_candidatesData);
        }
    }

    public void GetNewCandidates()
    {
        if(_candidatesDataCopy == null) {
            _candidatesDataCopy = Instantiate(_candidatesData);
        }

        if (_candidatesDataCopy.Candidates.Count == 0)
        {
            Debug.LogWarning("No more available condedats");
            return;
        }

        var firstCandidate = _candidatesDataCopy.Candidates[UnityEngine.Random.Range(0, _candidatesDataCopy.Candidates.Count)];

        _candidatesDataCopy.Candidates.Remove(firstCandidate);

        var secondCandidate = _candidatesDataCopy.Candidates.Where(candidate => candidate.Trait != firstCandidate.Trait).FirstOrDefault();

        _candidatesDataCopy.Candidates.Remove(secondCandidate);

        UpdateCandidate(_firstCandidateUI, firstCandidate);
        UpdateCandidate(_secondCandidateUI, secondCandidate);

        //return new List<Candidate> { firstCandidate, secondCandidate };
    }

    private void UpdateCandidate(CandidateUI candidateUI, Candidate candidate)
    {
        candidateUI.Photo.sprite = candidate.Image;
        candidateUI.Name.text = candidate.Name;
        candidateUI.Description.text = candidate.Description;
        candidateUI.Promise.text = candidate.Promise;
        candidateUI.VoteButton.onClick.AddListener(delegate { ChooseCandidate(candidate); });
    }

    private void ChooseCandidate(Candidate candidate)
    {
        _manager.CurrentCandidate = candidate;
    }
}
