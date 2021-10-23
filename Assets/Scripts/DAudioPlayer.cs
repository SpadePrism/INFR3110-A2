using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAudioPlayer : MonoBehaviour
{
    private AudioSource _audiosource;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Move.died += PlayAudio;
    }

    private void OnDisable()
    {
        Move.died -= PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.Play();
    }
}
