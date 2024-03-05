using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMusic : MonoBehaviour
{
    public AudioClip audioClip; // Asigna tu pista de audio en el Inspector
    [SerializeField]
    private AudioSource audioSource;

    void Start()
    {



        // Reproduce la pista de audio
        audioSource.Play();
    }

    // Método llamado al finalizar la reproducción de la pista de audio
    void OnAudioEnd()
    {
        // Si la reproducción ha llegado al final, reinicia la pista
        if (!audioSource.isPlaying)
        {
            audioSource.Stop();
            audioSource.Play();
        }
    }

    private void Update()
    {
        OnAudioEnd();
    }
}
