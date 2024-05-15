using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAsyncScenes : MonoBehaviour
{
    // Lista de nombres de escenas a cargar
    public List<string> scenesToLoad;

    // Índice de la escena activa actual
    private int currentSceneIndex = 0;

    void Start()
    {
        // Comienza la carga de escenas asincronas
        StartCoroutine(LoadScenesAsync());
    }

    // Corrutina para cargar las escenas de forma asíncrona
    private IEnumerator LoadScenesAsync()
    {
        //CARGAS asincronamente las scena b y c
        SceneManager.LoadSceneAsync(scenesToLoad[1], LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync(scenesToLoad[2], LoadSceneMode.Additive);
        yield return new WaitForSeconds(1f);
    }

    //activates scene by name and unload the latest scene
    public void ActivateScene(int currentSceneIndex)
    {
        //descargas escena anterior
        SceneManager.UnloadSceneAsync(scenesToLoad[currentSceneIndex]);
        //add 1 to the current scene index
        currentSceneIndex += 1;
        //activates the currentScene(B)
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(scenesToLoad[currentSceneIndex]));
        //take away the older scene(A)
    }
}
