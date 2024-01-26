using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] musicSounds, sfxSounds, dialogueSounds, transitionSounds;
    public AudioSource musicSource, sfxSource, sfxSource2, sfxSource3, dialogueSource, dialogueSource2, dialogueSource3, transitionSource, transitionSource2, transitionSource3;

    private void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        PlayMusic("Theme");
    }

    public void PlayMusic(string name)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if(s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }


    //SEGUNDO sonido VFX
    public void PlaySFX2(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(sfxSounds, x => x.name == name);

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

    //tercer sonido VFX
    public void PlaySFX3(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(sfxSounds, x => x.name == name);

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


    //sonidos de canvas como botones se llaman desde aqui

    public void PulsarBotonSound()
    {
        //sonido pala golpe al acabar animacion
        PlaySFX("Boton");
    }




    //primer sonido de dialogo
    public void PlayDialogue1(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(dialogueSounds, x => x.name == name);

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

    //segundo sonido de dialogo
    public void PlayDialogue2(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(dialogueSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            dialogueSource2.clip = s.clip;
            dialogueSource2.volume = volume;
            dialogueSource2.Play();
        }
    }

    //tercer sonido de dialogo
    public void PlayDialogue3(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(dialogueSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            dialogueSource3.clip = s.clip;
            dialogueSource3.volume = volume;
            dialogueSource3.Play();
        }
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

    

    

    //primer sonido VFX
   

    //primer sonido TRANSITION
    public void PlayTransition(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(transitionSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            transitionSource.volume = volume;
            transitionSource.PlayOneShot(s.clip);
        }
    }

    public void PlayTransition2(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(transitionSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            transitionSource2.volume = volume;
            transitionSource2.PlayOneShot(s.clip);
        }
    }
    public void PlayTransition3(string name, float volume)
    {
        //buscamos la musica que queremos poner en el musicSound
        Sound s = Array.Find(transitionSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            transitionSource3.volume = volume;
            transitionSource3.PlayOneShot(s.clip);
        }
    }

    public void StopSFX()
    {
        sfxSource.Stop();
        sfxSource2.Stop();
        sfxSource3.Stop();
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



    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void StopDialogue()
    {
        dialogueSource.Stop();
        dialogueSource2.Stop();
        dialogueSource3.Stop();
    }

    public void StopTransition()
    {
        transitionSource.Stop();

    }

   

    public void SFXVolume1(float volume)
    {
        sfxSource.volume = volume;
    }

    public void SFXVolume2(float volume)
    {
        sfxSource2.volume = volume;
    }

    public void SFXVolume3(float volume)
    {
        sfxSource3.volume = volume;
    }

    public void DialogueVolume(float volume)
    {
        dialogueSource.volume = volume;
    }

    public void DialogueVolume2(float volume)
    {
        dialogueSource2.volume = volume;
    }

    public void DialogueVolume3(float volume)
    {
        dialogueSource3.volume = volume;
    }

    public void TransitionVolume(float volume)
    {
        transitionSource.volume = volume;
    }
}
