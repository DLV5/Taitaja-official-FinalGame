using System.Collections;
using UnityEngine;

public class NewTurnUI : MonoBehaviour
{
    [SerializeField] private GameObject _panelToShow;

    public void StartNewTurnAnimation()
    {
        StartCoroutine(StartAndStopAfter());
    }

    private IEnumerator StartAndStopAfter()
    {
        _panelToShow.SetActive(true);
        yield return new WaitForSecondsRealtime(1.3f);
        AudioManager.Instance.PlaySFX("NewDaySound");
        yield return new WaitForSecondsRealtime(.3f);
        _panelToShow.SetActive(false);
    }
}
