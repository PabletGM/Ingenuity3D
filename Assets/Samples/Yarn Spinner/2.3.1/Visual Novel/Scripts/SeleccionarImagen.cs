using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SeleccionarImagen : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private Vector3 originalScale;

    [SerializeField]
    private Vector3 bigScale;

    void Start()
    {
        //originalScale = new Vector3(0.01f, 0.01f, 0.01f);
    }

    //nada mas activarse que se haga
    private void OnEnable()
    {
        this.gameObject.transform.DOScale(originalScale, 1f);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Cuando el rat�n entra en la imagen
        transform.localScale = bigScale; // Aumenta el tama�o en un 50%
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Cuando el rat�n sale de la imagen
        transform.localScale = originalScale; // Restaura el tama�o original
    }


    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
       

        //Use this to tell when the user left-clicks on the Button
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            //se activa boton continuar
        }
    }
}
