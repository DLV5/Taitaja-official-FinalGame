using UnityEngine;

public class RealWorldStickman : MonoBehaviour, ISpawnObject
{
    [SerializeField] private Animation _animation;
    private Animator Animator;
    private void Start()
    {
        Animator = GetComponentInChildren<Animator>();
        if (Animator == null)
            Debug.LogError("No animator");
    }
    public void Activate()
    {
       gameObject.SetActive(true);
    }
}
