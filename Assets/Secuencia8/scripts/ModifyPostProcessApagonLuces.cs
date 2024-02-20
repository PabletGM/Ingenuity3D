using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ModifyPostProcessApagonLuces : MonoBehaviour
{
    public Volume _ppv;
    private ShadowsMidtonesHighlights highlights;



    [Header("Parameters Change Highlights and Gain")]
    [SerializeField] private float initialHighlights;
    [SerializeField] private float finalHighlights;
    [SerializeField] private float changeDuration;
    // Duración de cada cambio en segundos

    void Start()
    {
        //asociamos vignette
        _ppv.profile.TryGet(out highlights);


        // Iniciar las corrutinas para subir y bajar la intensidad del vignette
        ModificarColorGrading();
       
    }

   

    private void ModificarColorGrading()
    {
        StartCoroutine(ChangeColorGradingParameters(initialHighlights, finalHighlights));
        Invoke("RestaurarColorGrading", changeDuration);
    }

    private void RestaurarColorGrading()
    {
        StartCoroutine(ChangeColorGradingParameters(finalHighlights, initialHighlights));
        Invoke("ModificarColorGrading", changeDuration);
    }

    IEnumerator ChangeColorGradingParameters(float startHighlights, float endHighlights)
    {
        float elapsedTime = 0f;
        float currentHighlights = startHighlights;


        while (elapsedTime < changeDuration)
        {
            currentHighlights = Mathf.Lerp(startHighlights, endHighlights, elapsedTime / changeDuration);


            highlights.highlights.value = new Vector4(currentHighlights, currentHighlights, currentHighlights, 0f);


            elapsedTime += Time.deltaTime;
            yield return null;
        }

        highlights.highlights.value = new Vector4(endHighlights, endHighlights, endHighlights, 0f);

    }
}
