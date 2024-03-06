using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;
using UnityEngine.Video;

public class TutorialManager : MonoBehaviour
{


    [Header("Reproductor y MenuInicio")]
    [SerializeField]
    private GameObject reproductor;
    [SerializeField]
    private GameObject menuInicio;



    [Header("Boton Play y portada y marco ")]
    [SerializeField]
    private GameObject botonPlayVideo;
    [SerializeField]
    private GameObject PortadaAntesDeVideo;
    [SerializeField]
    private GameObject marco;



    [Header("VideoTutorial")]
    [SerializeField]
    private GameObject video;
    [SerializeField]
    private VideoPlayer videoPlayer;



    bool verVideoCorrectWin = false;

    //al hacer click en boton video disco sobre otro correcto del menuInicio
    public void PlayVideoTutorial()
    {
        //cerramos menu inicio
        menuInicio.SetActive(false);
        //abrimos reproductor
        reproductor.SetActive(true);
        //ponemos portada
        PortadaAntesDeVideo.SetActive(true);
        marco.SetActive(true);
        botonPlayVideo.SetActive(true);
    }


    public void QuitPortadaImagen()
    {
        PortadaAntesDeVideo.SetActive(false);
        marco.SetActive(false);
        video.gameObject.SetActive(true);
        videoPlayer.Play();
        botonPlayVideo.SetActive(false);
    }

    

  

    public void SetVideoTutorial()
    {
        //cambiamos valor de estado
        verVideoCorrectWin = !verVideoCorrectWin;
        //este ocupa todo el video y es un panel que la opacidad es 0 al darle a play
        //si se esta viendo el video
        if (verVideoCorrectWin)
        {
            //quitamos portada
            marco.SetActive(false);
            PortadaAntesDeVideo.SetActive(false);
            botonPlayVideo.SetActive(false);
            //damos a Play el video
            video.gameObject.SetActive(true);
            videoPlayer.Play();

        }
        //sino se esta viendo el video
        else
        {
            //ponemos portada
            marco.SetActive(false);
            PortadaAntesDeVideo.SetActive(true);
            botonPlayVideo.SetActive(true);
            //paramos video
            video.gameObject.SetActive(false);
            videoPlayer.Stop();


        }

    }

    public void BackToMenuInicio()
    {
        //paramos ambos videos
        videoPlayer.Stop();

        //abrimos menu inicio
        menuInicio.SetActive(true);
        //cerramos reproductor
        reproductor.SetActive(false);
        //ponemos portada
        PortadaAntesDeVideo.SetActive(false);
        marco.SetActive(false);
        botonPlayVideo.SetActive(false);
    }

    public void IniciarPartida()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene(1, UnityEngine.SceneManagement.LoadSceneMode.Single);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Hanoi");
    }
}
