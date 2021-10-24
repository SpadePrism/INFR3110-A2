using UnityEngine;

public class JumpAudio : MonoBehaviour
{
    private AudioSource _audiosource;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Move.jumped += PlayAudio;
    }

    private void OnDisable()
    {
        Move.jumped -= PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.Play();
    }
}