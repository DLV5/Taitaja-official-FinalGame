using UnityEngine;

public class LegendsScreen : MonoBehaviour
{
    [SerializeField] private GameObject _scieceIcon;
    [SerializeField] private GameObject _merchantIcon;

    public void OnScientistChoosed()
    {
        _scieceIcon.SetActive(true);
        gameObject.SetActive(false);
    }
    
    public void OnMerchantChoosed()
    {
        _merchantIcon.SetActive(true);
        gameObject.SetActive(false);
    }
}
