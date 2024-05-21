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
        [field: SerializeField] public TMP_Text HungerStat { get; set; }
        [field: SerializeField] public TMP_Text WaterStat { get; set; }
        [field: SerializeField] public TMP_Text HealthStat { get; set; }
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

        var secondCandidate = _candidatesDataCopy.Candidates[UnityEngine.Random.Range(0, _candidatesDataCopy.Candidates.Count)];

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

        candidateUI.HungerStat.text = "Hunger";
        candidateUI.WaterStat.text = "Water";
        candidateUI.HealthStat.text = "Health";

        for (int i = 0; i < Math.Abs(candidate.HungerAffectionLevel); i++)
        {
            if(candidate.HungerAffectionLevel > 0)
            {
                candidateUI.HungerStat.text += "+";
            } else if(candidate.HungerAffectionLevel < 0)
            {
                candidateUI.HungerStat.text += "-";
            }
        }
        
        for (int i = 0; i < Math.Abs(candidate.WaterAffectionLevel); i++)
        {
            if(candidate.WaterAffectionLevel > 0)
            {
                candidateUI.WaterStat.text += "+";
            } else if(candidate.WaterAffectionLevel < 0)
            {
                candidateUI.WaterStat.text += "-";
            }
        
        }for (int i = 0; i < Math.Abs(candidate.HealthAffectionLevel); i++)
        {
            if(candidate.HealthAffectionLevel > 0)
            {
                candidateUI.HealthStat.text += "+";
            } else if(candidate.HealthAffectionLevel < 0)
            {
                candidateUI.HealthStat.text += "-";
            }
        }
        candidateUI.VoteButton.onClick.AddListener(delegate { ChooseCandidate(candidate); });
    }

    private void ChooseCandidate(Candidate candidate)
    {
        _manager.CurrentCandidate = candidate;
    }
}
