using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AudioManagerBengalas : MonoBehaviour
{
    public static AudioManagerBengalas instance;
    public SoundBengalas[] musicSounds, sfxSounds, dialogueSounds, transitionSounds;
    public AudioSource musicSource, sfxSource, sfxSource2, sfxSource3, dialogueSource, transitionSource;

    private bool canDestroy = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (canDestroy)
        {
            Destroy(this.gameObject);
            canDestroy = false;
        }
    }

    public void SetDestroy(bool set)
    {
        canDestroy = set;
    }



    private void Start()
    {
        //PlayMusicNature();
    }

    public void PlayMusicNature()
    {
        PlayMusic("nature",1f);
    }

    public void PlayMusic(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        SoundBengalas s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            musicSource.volume = volume;
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlayDialogue(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        SoundBengalas s = Array.Find(dialogueSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            dialogueSource.clip = s.clip;
            dialogueSource.volume = volume;
            dialogueSource.Play();
        }
    }

    public void PlayTransition(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        SoundBengalas s = Array.Find(transitionSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            transitionSource.clip = s.clip;
            transitionSource.volume = volume;
            transitionSource.Play();
        }
    }

    public void PlaySFX(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        SoundBengalas s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            sfxSource.volume = volume;
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void PlaySFX2(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        SoundBengalas s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            sfxSource2.volume = volume;
            sfxSource2.PlayOneShot(s.clip);
        }
    }

    public void PlaySFX3(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        SoundBengalas s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            sfxSource3.volume = volume;
            sfxSource3.PlayOneShot(s.clip);
        }
    }

    public void StopSFX1()
    {
        sfxSource.Stop();      
    }

    public void StopSFX2()
    {
        sfxSource2.Stop();
    }

    public void StopSFX3()
    {
        sfxSource3.Stop();
    }

    public void StopSFX()
    {
        sfxSource.Stop();
        sfxSource2.Stop();
        sfxSource3.Stop();
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }



    //sonidos de canvas como botones se llaman desde aqui

    public void PulsarBotonSound()
    {
        //sonido pala golpe al acabar animacion
        PlaySFX("clickButton",1f);
    }

    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

    public void DialogueVolume(float volume)
    {
        sfxSource.volume = volume;
    }

    public void BotonDialogos()
    {
        PlaySFX("clickButton", 1f);
    }
}
