using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class yarnSpinnerTemporizador : MonoBehaviour
{
    [SerializeField]
    private float contadorPasarSiguienteTexto;

    [SerializeField]
    private LineView pasarSiguienteTexto;

    public float actualTime = 0;

    // Método principal que se ejecuta al iniciar el script
   

    private void Update()
    {
        //si supera tiempo maximo
        if(actualTime >= contadorPasarSiguienteTexto)
        {
            // Realizar la acción click automatica
            pasarSiguienteTexto.OnContinueClicked();
            //reinicia contador
            actualTime = 0;
        }
        //suma al contador
        actualTime += Time.deltaTime;
    }

    public void ReiniciarTimer()
    {
        actualTime = 0;
    }
}
