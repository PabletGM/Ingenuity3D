using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resolucionPantalla : MonoBehaviour
{

    [SerializeField]
    private GameObject item16x9_1920x1080;

    [SerializeField]
    private GameObject item16x10;

    [SerializeField]
    private GameObject freeAspect;
    void Start()
    {
        // Obtenemos la resoluci�n actual de la pantalla
        int screenWidth = Screen.width;
        int screenHeight = Screen.height;

        //Calculamos la relaci�n de aspecto
        float aspectRatio = (float)screenWidth / (float)screenHeight;

        //Imprimimos la informaci�n en la consola
        Debug.Log("Resoluci�n de pantalla: " + screenWidth + "x" + screenHeight);

        //Determinamos la categor�a de la relaci�n de aspecto
        string aspectRatioCategory;

        if (aspectRatio >= 1.7f && aspectRatio < 1.8f)
        {
            aspectRatioCategory = "16:9";
            item16x9_1920x1080.SetActive(true);
        }
        else if (aspectRatio > 1.5f && aspectRatio < 1.7f)
        {
            aspectRatioCategory = "16:10";
            item16x10.SetActive(true);
        }
        //<1.5
        else
        {
            aspectRatioCategory = "Otro";
            Debug.Log(aspectRatioCategory);
            freeAspect.SetActive(true);
        }

        //Debug.Log(aspectRatio);
    }
}
