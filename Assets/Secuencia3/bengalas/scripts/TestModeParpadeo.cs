using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestModeParpadeo : MonoBehaviour
{
    public TMP_Text texto; // Referencia al objeto de texto que parpadear�
    private float contador= 0f;
    private float contadorMax = 1f;
    private bool estadoVisible = true; // Estado actual del texto (visible/invisible)
    private float tiempoUltimoCambio; // Tiempo del �ltimo cambio de estado

    private float escalaInicial = 1.0f; // Escala inicial del texto
    private float escalaFinal = 1.2f; // Escala final del texto
    private float duracion = 1f; // Duraci�n de la animaci�n del tween
    private RectTransform rectTransform; // Referencia al componente RectTransform del objeto
    private Vector3 escalaInicialVector;
    private Vector3 escalaFinalVector;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        escalaInicialVector = new Vector3(escalaInicial, escalaInicial, escalaInicial);
        escalaFinalVector = new Vector3(escalaFinal, escalaFinal, escalaFinal);

        // Si no se asigna un objeto de texto en el Inspector, intenta encontrar uno autom�ticamente en el mismo GameObject
        if (texto == null)
        {
            texto = GetComponent<TMP_Text>();
        }

        tiempoUltimoCambio = Time.time;
    }

    private void Update()
    {
        if (this.gameObject!=null)
        {
            contador += Time.deltaTime;
            if(contador>=contadorMax)
            {
                CambiarEstadoTexto();
                contador = 0f;
            }
        }
    }

    private void CambiarEstadoTexto()
    {
        CambiarSizeGrande();  
    }
    private void CambiarSizeGrande()
    {
        //tama�o
        rectTransform.DOScale(escalaFinalVector, duracion);
        Invoke("CambiarSizeSmall", duracion);
    }

    private void CambiarSizeSmall()
    {
        //tama�o
        rectTransform.DOScale(escalaInicialVector, duracion);
        Invoke("CambiarSizeGrande", duracion);
    }
}

