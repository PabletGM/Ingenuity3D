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
    private GameObject item16x10_16x9;
    void Start()
    {
        // Obtenemos la resolución actual de la pantalla
        int screenWidth = Screen.width;
        int screenHeight = Screen.height;

        //Calculamos la relación de aspecto
        float aspectRatio = (float)screenWidth / (float)screenHeight;

        //Imprimimos la información en la consola
        Debug.Log("Resolución de pantalla: " + screenWidth + "x" + screenHeight);

        //Determinamos la categoría de la relación de aspecto
        string aspectRatioCategory;

        if (aspectRatio > 1.7f && aspectRatio < 1.8f)
        {
            aspectRatioCategory = "16:9";
            item16x9_1920x1080.SetActive(true);
        }
        else if (aspectRatio > 1.5f && aspectRatio < 1.6f)
        {
            aspectRatioCategory = "16:10";
            item16x10.SetActive(true);
        }
        else
        {
            aspectRatioCategory = "Otro";
            item16x10_16x9.SetActive(true);
        }

        Debug.Log("Relación de aspecto: " + aspectRatioCategory);
    }
}
