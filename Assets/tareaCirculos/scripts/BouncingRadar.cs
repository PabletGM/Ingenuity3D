using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingRadar : MonoBehaviour
{
    public float speed; // Velocidad de movimiento del sprite
    public float minX; // L�mite izquierdo de la pantalla
    public float maxX;  // L�mite derecho de la pantalla
    public float minY; // L�mite inferior de la pantalla
    public float maxY;  // L�mite superior de la pantalla

    private Vector2 direction; // Direcci�n inicial del movimiento



    private void Start()
    {
        //direccion inicial del movimiento, arriba derecha
        direction = new Vector2(1, 1);
        //quita la velocidad hasta que empiece la ronda
        ChangeSpeedSin();
    }

    void Update()
    {
        // Calcula la nueva posici�n del sprite
        Vector2 newPosition = (Vector2)transform.position + direction * speed * Time.deltaTime;

        // Verifica si el sprite ha alcanzado los l�mites de la pantalla
        if (newPosition.x <= minX || newPosition.x >= maxX)
        {
            // Cambia la direcci�n horizontal para invertir el movimiento
            direction.x *= -1;
        }

        if (newPosition.y <= minY || newPosition.y >= maxY)
        {
            // Cambia la direcci�n vertical para invertir el movimiento
            direction.y *= -1;
        }

        // Actualiza la posici�n del sprite
        transform.position = newPosition;
    }

    public void ChangeSpeedSin()
    {
        speed = 0;
    }

    public void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
