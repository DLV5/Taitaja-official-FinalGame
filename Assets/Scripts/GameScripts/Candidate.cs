using System;
using UnityEngine;

[Serializable]
public class Candidate
{
    [field :SerializeField] public string Name {  get; set; }
    [field :SerializeField] public string Description {  get; set; }
    [field :SerializeField] public string Promise {  get; set; }

    [field :SerializeField] public string RelatedNews {  get; set; }
    [field :SerializeField] public Sprite RelatedBackGround {  get; set; }

    [field :SerializeField] public int HungerAffectionLevel {  get; set; }
    [field :SerializeField] public int WaterAffectionLevel {  get; set; }
    [field :SerializeField] public int HealthAffectionLevel {  get; set; }

    [field :SerializeField] public Sprite Image {  get; set; }
}
