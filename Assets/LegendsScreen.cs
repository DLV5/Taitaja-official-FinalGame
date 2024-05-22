using UnityEngine;

public class LegendsScreen : MonoBehaviour
{
    [SerializeField] private GameObject _webSiteIcon;
    [SerializeField] private GameObject _scieceIcon;
    [SerializeField] private GameObject _merchantIcon;

    [SerializeField] private GameObject _exitInternetButton;

    public void OnScientistChoosed()
    {
        _webSiteIcon.SetActive(false);
        _scieceIcon.SetActive(true);
        gameObject.SetActive(false);
        _exitInternetButton.SetActive(true);
    }
    
    public void OnMerchantChoosed()
    {
        _webSiteIcon.SetActive(false);
        _merchantIcon.SetActive(true);
        gameObject.SetActive(false);
        _exitInternetButton.SetActive(true);
    }
}
