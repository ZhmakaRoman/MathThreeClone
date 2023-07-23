using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private ElementRemovalMechanism _element;


    private void Awake()
    {
        _element.OnSoundDestroyEvent += TurnAudioDestruction;
    }

    private void TurnAudioDestruction()
    {
        _audioSource.Play();
    }


    private void OnDestroy()
    {
        _element.OnSoundDestroyEvent -= TurnAudioDestruction;
    }
}