using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FinishCredits : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer videoPlayer;

    [SerializeField]
    private GameObject nextScene;

    void Start()
    {

        // Asegurarse de que el videoPlayer no sea nulo
        if (videoPlayer != null)
        {
            // Suscribir al evento loopPointReached, que se llama cuando el vídeo termina
            videoPlayer.loopPointReached += OnVideoEnd;
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        nextScene.GetComponent<NextSceneGenericMethod2>().NextScene();
    }
}
