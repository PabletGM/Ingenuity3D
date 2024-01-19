using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using System;

public class ComportamientoBotonStart : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    GameManagerTareaBengalas _myGameManagerBengalas;
    //tiempo que lleva el timer de bengala desde que despega
    private float restante=0;
    //permiso para volar la bengala
    private bool enMarcha = false;

    [SerializeField]
    private float tiempoMaximoLanzamientoAutomatico;
    //permitir lanzamiento autom�tico 1 vez en cada tirada
    [NonSerialized]
    public bool permitirLanzamientoAutomatico = true;


    public Image imagenParaAgrandar; // Referencia a la imagen que quieres agrandar
    private float escalaFinal = 1.35f; // Tama�o final al que se agrandar� la imagen
    private float duracionTween = 2f; // Duraci�n de la animaci�n de agrandamiento

    private Vector3 escalaOriginal; // Tama�o original de la imagen


    // Start is called before the first frame update
    void Start()
    {
        _myGameManagerBengalas = GameManagerTareaBengalas.GetInstanceGM();
        // Guardamos el tama�o original de la imagen
        escalaOriginal = imagenParaAgrandar.transform.localScale;
    }

    #region Pulsar boton

        //accion cuando se presiona boton
        public void OnPointerDown(PointerEventData eventData)
        {
            // Acci�n cuando se presiona el bot�n
            BotonPulsado();

            // Realizamos el tween para agrandar la imagen
            imagenParaAgrandar.transform.DOScale(escalaFinal, duracionTween);
        }

        //si se pulsa boton se inicia timer
        public void BotonPulsado()
        {
            //iniciamos timer
            enMarcha = true;

            //sonido boton
            AudioManagerBengalas.instance.PulsarBotonSound();
           
        }

    #endregion

    #region EfectoSoltarBoton
        public void LanzamientoCohete()
        {
            //inicialmente queremos que el cohete suba al pulsar el boton
            _myGameManagerBengalas.LanzamientoCohete(restante);

        }
    #endregion

    #region Soltar boton

            //accion cuando se suelta boton
            public void OnPointerUp(PointerEventData eventData)
            {
                // Acci�n cuando se suelta el bot�n
                BotonSoltado();

                // Volver al tama�o original con otro tween
                imagenParaAgrandar.transform.DOScale(escalaOriginal, duracionTween);
                
            }
            //si se suelta el boton se para el timer
            public void BotonSoltado()
            {
                //timer para
                enMarcha = false;
                //lanzamos cohete
                LanzamientoCohete();
                //reiniciamos timer
                restante = 0;
            }

    #endregion

   

    //comprueba el timer y limite de tiempo
    void Update()
    { 
        #region timer
            //si se ha pulsado boton se inicia timer
            if (enMarcha)
            {
                //va sumando segundos
                restante += Time.deltaTime;
                //debe haber un tiempo maximo controlado que si est� pulsando el player durante m�s de x segundos que se lance automaticamente
                if(restante > tiempoMaximoLanzamientoAutomatico && permitirLanzamientoAutomatico)
                {
                    //lanzamiento autom�tico
                    LanzamientoAutomatico();
                }
                Debug.Log("Button pressed: " + restante);
                
            }
        #endregion

    }


    private void LanzamientoAutomatico()
    {
        //SIMULAMOS ACCION DE CUANDO SE SUELTA BOTON
        // Acci�n cuando se suelta el bot�n
        BotonSoltado();
        // Volver al tama�o original con otro tween
        imagenParaAgrandar.transform.DOScale(escalaOriginal, duracionTween);



        //quitamos funcionalidad del boton y la ponemos otra vez luego para que lo suelte el player sin querer
        UIManagerTareaBengalas.GetInstanceUI().SetBoton(false);
        //quitamos permiso de lanzamiento autom�tico
        permitirLanzamientoAutomatico = false;
    }
}
