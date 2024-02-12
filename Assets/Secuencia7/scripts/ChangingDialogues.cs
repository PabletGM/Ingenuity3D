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
        if(ElegirCaminoMapa.instance != null)
        {
            string opcionElegida = ElegirCaminoMapa.instance.GetChosenOption();
            //segun la opcion que sea pone un texto u otro
            switch (opcionElegida)
            {
                case "Rio":
                    textToModify.text = "Tu decisi�n de cruzar el r�o no ha sido la m�s adecuada.�Es la opci�n m�s peligrosa y puede que nunca lleguemos a nuestro destino.";
                    break;

                case "CaminoEstablecido":
                    textToModify.text = "Tu decisi�n de ir por el camino establecido no ha sido la m�s acertada. Tardaremos mucho m�s y no podemos permitirnos perder m�s tiempo.�";
                    break;

                case "Bosque":
                    textToModify.text = "Tu decisi�n de atravesar la selva no ha sido la m�s adecuada.�Es la opci�n m�s peligrosa y puede que nunca lleguemos a nuestro destino.";
                    break;
            }
        }
        
    }
}
