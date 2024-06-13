using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetActiveTerminarTarea : MonoBehaviour
{

    [SerializeField]
    private GameObject buttonFinish;
    public void ActivateFinishButton()
    {
        //activates functionality button
        buttonFinish.GetComponent<Button>().interactable = true;
        //activate hover
        buttonFinish.GetComponentInParent<SeleccionarImagen>().enabled = true;
        //activate opacity panel
        Transform parentTransform = buttonFinish.transform.parent;
        Image parentImage = parentTransform.GetComponent<Image>();
        if (parentImage != null)
        {
            Debug.Log("Parent Image: " + parentImage.gameObject.name);
            Color color = parentImage.color;
            color.a = 1f; // Cambia el valor de alfa
            parentImage.color = color;
        }

        // Activa la opacidad del texto en el hijo
        Transform childrenTransform = buttonFinish.transform.GetChild(0);
        TMP_Text text = childrenTransform.GetComponent<TMP_Text>();
        if (text != null)
        {
            Debug.Log("Child Text: " + text.gameObject.name);
            Color textColor = text.color;
            textColor.a = 1f; // Cambia el valor de alfa
            text.color = textColor;
        }

    }
}
