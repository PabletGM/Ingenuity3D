using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoAstronauta : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(-3.13f, -4f, -2.1f); // Posici�n a la que se mover� el sprite
    public Quaternion targetRotation = Quaternion.Euler(1f, 180f, 40f); // Rotaci�n a la que se rotar� el sprite
    public float duracionMovimiento = 0.5f; // Duraci�n del movimiento
    public float duracionRotacion = 0.5f; // Duraci�n de la rotaci�n

    private Vector3 posicionInicial;
    private Quaternion rotacionInicial;

    private void Start()
    {
        // Guarda la posici�n y rotaci�n inicial
        posicionInicial = transform.position;
        rotacionInicial = transform.rotation;

       
    }

    public void AnimacionEncenderBengala()
    {
        // Inicia la animaci�n de movimiento y rotaci�n
        MoverYRotarSprite();
    }

    private void MoverYRotarSprite()
    {
        // Mueve el sprite a la posici�n deseada y lo rota hacia la rotaci�n deseada usando Tween
        var movimientoTween = transform.DOMove(targetPosition, duracionMovimiento);
        var rotacionTween = transform.DORotateQuaternion(targetRotation, duracionRotacion);

        // Cuando ambas animaciones se completan, restaura el estado original
        DOTween.Sequence().Append(movimientoTween).Append(rotacionTween).OnComplete(() => RestaurarEstadoOriginal());
    }

    private void RestaurarEstadoOriginal()
    {
        //sonido mechero y mecha
        AudioManagerBengalas.instance.PlaySFX("mecheroMecha",1f);
        // Restaura la posici�n y rotaci�n original del sprite usando Tween inversos
        var movimientoTween = transform.DOMove(posicionInicial, duracionMovimiento);
        var rotacionTween = transform.DORotate(rotacionInicial.eulerAngles, duracionRotacion);

        // Cuando ambas animaciones se completan, puedes realizar acciones adicionales si es necesario
        DOTween.Sequence().Append(movimientoTween).Append(rotacionTween);
    }
}
