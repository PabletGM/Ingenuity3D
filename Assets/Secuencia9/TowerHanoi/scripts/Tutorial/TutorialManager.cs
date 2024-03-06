using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class TutorialManager : MonoBehaviour
{
    [SerializeField]
    private GameObject reproductor;


    [SerializeField]
    private GameObject menuInicio;

    [SerializeField]
    private Button PanelbotonPlayVideoCorrectWin;









    [SerializeField]
    private GameObject videoCorrect;

    [SerializeField]
    private VideoPlayer videoPlayerCorrect;

    bool verVideoCorrectWin = false;

    private void Start()
    {

        videoPlayerCorrect = videoCorrect.GetComponent<VideoPlayer>();

    }

    //al hacer click en boton video disco sobre otro correcto del menuInicio
    public void PlayVideoTutorial()
    {
        //cerramos menu inicio
        menuInicio.SetActive(false);
        //abrimos reproductor
        reproductor.SetActive(true);

    }

    

  

    public void SetVideoTutorial()
    {
        //cambiamos valor de estado
        verVideoCorrectWin = !verVideoCorrectWin;
        //este ocupa todo el video y es un panel que la opacidad es 0 al darle a play
        //si se esta viendo el video
        if (verVideoCorrectWin)
        {
            //damos a Play el video
            videoCorrect.gameObject.SetActive(true);
            videoPlayerCorrect.Play();

        }
        //sino se esta viendo el video
        else
        {
            videoCorrect.gameObject.SetActive(false);
            videoPlayerCorrect.Stop();


        }

    }

    public void BackToMenuInicio()
    {
        //paramos ambos videos
        videoPlayerCorrect.Stop();

        //abrimos menu inicio
        menuInicio.SetActive(true);
        //cerramos reproductor
        reproductor.SetActive(false);
    }

    public void IniciarPartida()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene(1, UnityEngine.SceneManagement.LoadSceneMode.Single);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Hanoi");
    }
}
