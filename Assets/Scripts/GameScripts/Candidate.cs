using UnityEngine;

public class Candidate : MonoBehaviour
{
    [field :SerializeField] public string Name {  get; set; }
    [field :SerializeField] public string Description {  get; set; }
    [field :SerializeField] public string Promise {  get; set; }

    [field :SerializeField] public string RelatedNews {  get; set; }
    [field :SerializeField] public Sprite RelatedBackGround {  get; set; }

    [field :SerializeField] public Sprite Image {  get; set; }

    [field :SerializeField] public Trait Trait {  get; set; }
}
