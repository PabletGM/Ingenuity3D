using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBackground : MonoBehaviour
{
    public Transform backgroundTransform;
    public float moveSpeed; // Velocidad de movimiento del fondo.
    public float moveDuration; // Duraci�n de la animaci�n en segundos.

    private bool isMoving = false;
    private float startTime;

    [SerializeField] private GameObject robot;

    private float duracionAnimacion = 1.2f;

    [SerializeField]
    private GameObject DialoguePanel;

    private void Start()
    {
        // Al inicio, aseg�rate de que el fondo no se est� moviendo.
        isMoving = false;
        StartMove();
        //a los 2 segundos invocas el texto para que empiece el textManager
        Invoke("ComenzarTextoRobot", 2f);

    }

    private void ComenzarTextoRobot()
    {
        //inicias robot
        robot.SetActive(true);
        Invoke("DialogoPanel", 1f);
        
    }

    private void DialogoPanel()
    {
        //activamos texto y animacion robot
        DialoguePanel.SetActive(true);
        TweenAumentarTama�oDialogo();
    }

    public void TweenAumentarTama�oDialogo()
    {
        //1 segundo de tween 
        DialoguePanel.transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 1f);

    }

    private void Update()
    {
        // Si el fondo est� en movimiento, actualiza su posici�n.
        if (isMoving)
        {
            float elapsedTime = Time.time - startTime;
            if (elapsedTime < moveDuration)
            {
                float moveDistance = moveSpeed * Time.deltaTime;
                backgroundTransform.Translate(Vector3.left * moveDistance);
            }
            else
            {
                // Det�n el movimiento despu�s de la duraci�n especificada.
                isMoving = false;
                
            }
        }
    }


    public void StartMove()
    {
        // Comienza el movimiento cuando se llama a este m�todo.
        if (!isMoving)
        {
            startTime = Time.time;
            isMoving = true;
        }
    }

    //public void EmpezarGameCirculos()
    //{
    //    SceneManager.LoadScene("PanelRadar");
    //}
}

