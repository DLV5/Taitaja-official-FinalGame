using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CandidatesData", menuName = "ScriptableObjects/CandidatesDataScriptableObject", order = 1)]
public class CandidatesData : ScriptableObject
{
    [field: SerializeField] public List<Candidate> Candidates {  get; private set; }
}