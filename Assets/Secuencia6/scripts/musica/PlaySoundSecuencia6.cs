using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundSecuencia6 : MonoBehaviour
{
    [Header("Sound SFX")]
    [SerializeField]
    private float volumeSFX1;
    [SerializeField]
    private float volumeSFX2;
    [SerializeField]
    private float volumeSFX3;

    [Header("Sound Music")]
    [SerializeField]
    private float volumeMusic;

    [Header("Sound Dialogue")]
    [SerializeField]
    private float volumeDialogue1;
    [SerializeField]
    private float volumeDialogue2;
    [SerializeField]
    private float volumeDialogue3;

    [Header("Sound Transition")]
    [SerializeField]
    private float volumeTransition;



    public static PlaySoundSecuencia6 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



    #region SFX
    public void PlaySFX1(string sfx1)
    {
        AudioManager.Instance.PlaySFX(sfx1);
    }

    public void PlaySFX2(string sfx2)
    {
        AudioManager.Instance.PlaySFX2(sfx2, volumeSFX2);
    }

    public void PlaySFX3(string sfx3)
    {
        AudioManager.Instance.PlaySFX3(sfx3, volumeSFX3);
    }

    public void ChangeVolumeSFX1(float volume)
    {
        volume = volumeSFX1;
    }

    public void ChangeVolumeSFX2(float volume)
    {
        volume = volumeSFX2;
    }

    public void ChangeVolumeSFX3(float volume)
    {
        volume = volumeSFX3;
    }

    public void StopAllSFX()
    {
        AudioManager.Instance.StopSFX();
    }

    public void stopSFX1(string sfx1)
    {
        AudioManager.Instance.StopSFX1();
    }

    public void stopSFX2(string sfx2)
    {
        AudioManager.Instance.StopSFX2();
    }

    public void stopSFX3(string sfx3)
    {
        AudioManager.Instance.StopSFX3();
    }



    #endregion


    //=================================================================================================


    #region Music
    public void PlayMusic(string music)
    {
        AudioManager.Instance.PlayMusic(music);
    }

    public void ChangeVolumeMusic(float volume)
    {
        volume = volumeMusic;
    }

    public void StopAllMusic()
    {
        AudioManager.Instance.StopMusic();
    }
    #endregion



    //=================================================================================================

    #region Dialogue
    public void PlayDialogue1(string music)
    {
        AudioManager.Instance.PlayDialogue1(music, volumeDialogue1);
    }

    public void PlayDialogue2(string music)
    {
        AudioManager.Instance.PlayDialogue2(music, volumeDialogue2);
    }

    public void PlayDialogue3(string music)
    {
        AudioManager.Instance.PlayDialogue3(music, volumeDialogue3);
    }

    public void ChangeVolumeDialogue1(float volume)
    {
        volume = volumeDialogue1;
    }

    public void ChangeVolumeDialogue2(float volume)
    {
        volume = volumeDialogue2;
    }

    public void ChangeVolumeDialogue3(float volume)
    {
        volume = volumeDialogue3;
    }

    public void StopAllDialogue()
    {
        AudioManager.Instance.StopDialogue();
    }
    #endregion


    //=================================================================================================

    #region Transition

    public void PlayTransition(string music)
    {
        AudioManager.Instance.PlayTransition(music, volumeTransition);
    }
    public void PlayTransition2(string music)
    {
        AudioManager.Instance.PlayTransition2(music, volumeTransition);
    }

    public void PlayTransition3(string music)
    {
        AudioManager.Instance.PlayTransition3(music, volumeTransition);
    }



    public void ChangeVolumeTransition(float volume)
    {
        volume = volumeTransition;
    }

    public void StopAllTransition()
    {
        AudioManager.Instance.StopTransition();
    }
    #endregion
}
