using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeVolumeAudioSource : MonoBehaviour
{

    public float fadeDuration; // Duration of the fade-out in seconds

    private AudioSource audioSource;



    private void Start()
    {
        #region AudioManagerSec3
        // Busca el GameObject llamado "AudioManagerBengalasSecuencia3" en la jerarquía, audioManager sec3
        GameObject audioManager = GameObject.Find("AudioManagerBengalasSecuencia3");

        if (audioManager != null)
        {
            // Busca el hijo llamado "Music Source"
            Transform musicSourceTransform = audioManager.transform.Find("Music Source");

            if (musicSourceTransform != null)
            {
                // Obtén el componente AudioSource del hijo "Music Source"
                audioSource = musicSourceTransform.GetComponent<AudioSource>();

                Debug.Log("Found audioSource: " + audioSource);
            }
        }

        #endregion

        #region AudioManagerSec4
        // Busca el GameObject llamado "AudioManagerBengalasSecuencia3" en la jerarquía, audioManager sec3
        GameObject audioManagerSec4 = GameObject.Find("AudioManagerSecuencia4");

        if (audioManagerSec4 != null)
        {
            // Busca el hijo llamado "Music Source"
            Transform musicSourceTransform = audioManagerSec4.transform.Find("Music Source");

            if (musicSourceTransform != null)
            {
                // Obtén el componente AudioSource del hijo "Music Source"
                audioSource = musicSourceTransform.GetComponent<AudioSource>();

                Debug.Log("Found audioSource: " + audioSource);
            }
        }
        #endregion

        #region AudioManagerSec5
        // Busca el GameObject llamado "AudioManagerBengalasSecuencia3" en la jerarquía, audioManager sec3
        GameObject audioManagerSec5 = GameObject.Find("AudioManagerSecuencia4");

        if (audioManagerSec5 != null)
        {
            // Busca el hijo llamado "Music Source"
            Transform musicSourceTransform = audioManagerSec5.transform.Find("Music Source");

            if (musicSourceTransform != null)
            {
                // Obtén el componente AudioSource del hijo "Music Source"
                audioSource = musicSourceTransform.GetComponent<AudioSource>();

                Debug.Log("Found audioSource: " + audioSource);
            }
        }
        #endregion

        #region AudioManagerSec7
        // Busca el GameObject llamado "AudioManagerBengalasSecuencia3" en la jerarquía, audioManager sec3
        GameObject audioManagerSec7 = GameObject.Find("AudioManagerSecuencia7");

        if (audioManagerSec7 != null)
        {
            // Busca el hijo llamado "Music Source"
            Transform musicSourceTransform = audioManagerSec7.transform.Find("Music Source");

            if (musicSourceTransform != null)
            {
                // Obtén el componente AudioSource del hijo "Music Source"
                audioSource = musicSourceTransform.GetComponent<AudioSource>();

                Debug.Log("Found audioSource: " + audioSource);
            }
        }
        #endregion
    }





    // Call this method to start fading out the audio
    public void StartFadeOut()
    {
        if(audioSource != null)
        {
            StartCoroutine(FadeOutCoroutine());
        }
        
    }

    public void StartFadeIn()
    {
        if (audioSource != null)
        {
            StartCoroutine(FadeInCoroutine());
        }

    }

    private IEnumerator FadeOutCoroutine()
    {
        float startVolume = audioSource.volume;
        float startTime = Time.time;

        while (Time.time < startTime + fadeDuration)
        {
            audioSource.volume = Mathf.Lerp(startVolume, 0, (Time.time - startTime) / fadeDuration);
            yield return null;
        }

        audioSource.volume = 0;
        audioSource.Stop(); // Optional: stop the audio source if desired
    }

    public IEnumerator FadeInCoroutine()
    {
        audioSource.volume = 0;
        audioSource.Play(); // Optional: play the audio source if it's not already playing

        float targetVolume = 0.1f;
        float startTime = Time.time;

        while (Time.time < startTime + fadeDuration)
        {
            audioSource.volume = Mathf.Lerp(0, targetVolume, (Time.time - startTime) / fadeDuration);
            yield return null;
        }

        audioSource.volume = targetVolume;
    }


}
