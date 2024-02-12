using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingDialogues : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textToModify;

    [SerializeField]
    private string nameActualScene;

    private void Update()
    {
        //miramos cual es la escena actual
        if(nameActualScene == "7.8DialogoOpciones")
        {
            ChangeTextWithOption();
        }
    }

   private void ChangeTextWithOption()
   {
        //si estamos dentro buscamos saber opcion escogida
        string opcionElegida = ElegirCaminoMapa.instance.GetChosenOption();
        //segun la opcion que sea pone un texto u otro
        switch(opcionElegida)
        {
            case "Rio":
                textToModify.text = "Tu decisión de cruzar el río no ha sido la más adecuada. ";
                break;

            case "CaminoEstablecido":
                textToModify.text = "Tu decisión de ir por el camino establecido no ha sido la más acertada.  ";
                break;

            case "Bosque":
                textToModify.text = "Tu decisión de atravesar la selva no ha sido la más adecuada. ";
                break;
        }
    }
}
