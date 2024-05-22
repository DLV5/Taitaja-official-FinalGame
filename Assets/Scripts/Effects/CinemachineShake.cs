using Cinemachine;
using UnityEngine;

public class CinemachineShake : MonoBehaviour
{
    [SerializeField] private float _intensivity;
    [SerializeField] private float _time;
    private float shakeTimer;
    private CinemachineVirtualCamera _cinemachineVirtualCamera;

    private void Awake()
    {
        _cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    public void ShakeCamera()
    {
        var _cinemachineBasicMultiChannelPerlin = _cinemachineVirtualCamera
            .GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        
        _cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = _intensivity;

        shakeTimer = _time;
    }

    private void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer <= 0)
            {
                var _cinemachineBasicMultiChannelPerlin = _cinemachineVirtualCamera
                .GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                _cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0;
            }
        }
    }
}
