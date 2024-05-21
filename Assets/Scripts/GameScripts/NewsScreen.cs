using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsScreen : MonoBehaviour
{
    [Serializable]
    public class Commentary
    {
        [field: SerializeField] public Image Photo { get; set; }
        [field: SerializeField] public string Name { get; set; }
        [field: SerializeField] public string CommentaryText { get; set; }
        [field: SerializeField] public Trait PositiveOrNegative { get; set; }
    }

    [SerializeField] private Image _photo;
    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _relatedNews;

    [SerializeField] private List<Commentary> _commentaries = new List<Commentary>();

    public void UpdateNews(Candidate candidate)
    {
        _photo.sprite = candidate.Image;
        _title.text = $"{candidate.Name}, was elected!";
        _relatedNews.text = candidate.RelatedNews;
    }
}
