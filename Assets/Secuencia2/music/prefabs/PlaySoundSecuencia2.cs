using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundSecuencia2 : MonoBehaviour
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



    public static PlaySoundSecuencia2 instance;
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
        AudioManagerCirculos.instance.PlaySFX(sfx1, volumeSFX1);
    }

    public void PlaySFX2(string sfx2)
    {
        AudioManagerCirculos.instance.PlaySFX2(sfx2, volumeSFX2);
    }

    public void PlaySFX3(string sfx3)
    {
        AudioManagerCirculos.instance.PlaySFX3(sfx3, volumeSFX3);
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
        AudioManagerCirculos.instance.StopSFX();
    }

    public void stopSFX1(string sfx1)
    {
        AudioManagerCirculos.instance.StopSFX1();
    }

    public void stopSFX2(string sfx2)
    {
        AudioManagerCirculos.instance.StopSFX2();
    }

    public void stopSFX3(string sfx3)
    {
        AudioManagerCirculos.instance.StopSFX3();
    }



    #endregion


    //=================================================================================================


    #region Music
    public void PlayMusic(string music)
    {
        AudioManagerCirculos.instance.PlayMusic(music);
    }

    public void ChangeVolumeMusic(float volume)
    {
        volume = volumeMusic;
    }

    public void StopAllMusic()
    {
        AudioManagerCirculos.instance.StopMusic();
    }
    #endregion



    //=================================================================================================

    #region Dialogue
    public void PlayDialogue1(string music)
    {
        AudioManagerCirculos.instance.PlayDialogue(music, volumeDialogue1);
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

   
    #endregion


    //=================================================================================================

    #region Transition

    public void PlayTransition(string music)
    {
        AudioManagerCirculos.instance.PlayTransition(music, volumeTransition);
    }
   



    public void ChangeVolumeTransition(float volume)
    {
        volume = volumeTransition;
    }

   
    #endregion
}
