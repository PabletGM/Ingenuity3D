using UnityEngine;

public class ZoomOut : MonoBehaviour
{
    public Camera camara; // Referencia a la c�mara que deseas modificar
    private float aumentoMaximo = 12.0f; // Tama�o m�ximo al que quieres aumentar la c�mara
    private float velocidadAumento = 0.5f; // Velocidad a la que aumenta el tama�o de la c�mara


    

    private bool able = true;

    [SerializeField]
    private GameObject explosion;


    private void Update()
    {
        if(able)
        {
            // Aumenta el tama�o gradualmente mientras no haya alcanzado el l�mite
            if (camara.orthographicSize < aumentoMaximo)
            {
                float nuevoTama�o = Mathf.Lerp(camara.orthographicSize, aumentoMaximo, velocidadAumento * Time.deltaTime);
                camara.orthographicSize = nuevoTama�o;
            }
            //si ha alcanzado el limite
            if (camara.orthographicSize > 8)
            {
                able = false;
                //se activa boton
                //llamamos a play para iniciar animacion
                explosion.GetComponent<Explosion>().Play();
            }
        }
       
    }

}
