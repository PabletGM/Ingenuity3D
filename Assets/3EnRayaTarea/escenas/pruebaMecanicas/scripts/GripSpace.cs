using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GripSpace : MonoBehaviour
{
    public Button button;
    public TMP_Text buttonText;
    public string playerSide;
    [SerializeField]
    private gamecontroller GameController;

    [SerializeField]
    private GameObject fichaX;
    [SerializeField]
    private GameObject ficha0;

    public void SetSpace()
    {
         //aqui empieza turno jugador desde que tienes posibilidad de pulsar algun boton

        //si el boton es interactivo
        if (this.gameObject.GetComponent<Button>().interactable)
        {


            //siempre ponemos la X de player ya que solo se pulsa boton en nuestro turno
            buttonText.text = "X";
            ActivarFichaPlayerSprite();
            FichaPlayerSound();
            //al acabar de pulsarse el boton, acaba el turno del jugador y empieza el del enemigo
            gamecontroller.GetInstanceGameController().EmpezarTurnoEnemigo();
            //ponemos posicion como ocupada
            gamecontroller.GetInstanceGameController().PosicionBotonPulsadoOcupada(this.gameObject);
            //ya no es accesible
            this.gameObject.GetComponent<Button>().interactable = false;
            //metodo para buscar combinacion de 2 de 2 00 o 2 XX, para a�adir posibles posiciones de victoria
            gamecontroller.GetInstanceGameController().Combinacion200XX();
            //despues de eso se reinicia el contador
            gamecontroller.GetInstanceGameController().ReiniciarContador();


            gamecontroller.GetInstanceGameController().SetPanelEnemyWaiting();
            Invoke("TurnoEnemy", 1.5f);

        }
    }

    private void ActivarFichaPlayerSprite()
    {
        fichaX.SetActive(true);
    }

    public void ActivarFichaEnemySprite()
    {
        ficha0.SetActive(true);
    }

    public void FichaPlayerSound()
    {
        AudioManagerSecuencia6.instance.PlaySFX1("placeFichaPlayer", 0.3f);
       
        
    }

    void TurnoEnemy()
    {

        //turno enemy
        gamecontroller.GetInstanceGameController().EndTurn();
    }

    public void SetGameControllerReference(gamecontroller controller)
    {
        GameController = controller;
    }
}
