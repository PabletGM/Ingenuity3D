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
                    textToModify.text = "Cruzar el río no ha sido lo más adecuado. Es la opción más peligrosa y puede que nunca lleguemos a nuestro destino";
                    break;

                case "CaminoEstablecido":
                    textToModify.text = "Ir por el camino establecido no ha sido lo más acertado. Tardaremos mucho más y no podemos permitirnos perder más tiempo.";
                    break;

                case "Bosque":
                    textToModify.text = "Atravesar el bosque no ha sido lo más acertado. Es la opción más peligrosa y puede que nunca lleguemos a nuestro destino";
                    break;
            }
        }
        
    }
}
