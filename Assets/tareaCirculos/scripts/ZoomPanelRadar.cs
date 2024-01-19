using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoomPanelRadar : MonoBehaviour
{
    public bool ZoomActive;
    public Camera cam;
    public float speed;
    public float zoomDuration = 1.0f; // Duraci�n total del efecto de zoom
    public Transform zoomTarget; // La posici�n hacia la que se realizar� el zoom
    private Vector3 originalPosition;
    private Vector3 zoomPosition;
    private float zoomOrthographicSize = 1.5f;
    private float originalOrthographicSize = 3f;
    private float zoomStartTime;

    [SerializeField]
    private GameObject boton;

    private void Start()
    {
        cam = Camera.main;
        originalPosition = cam.transform.position;
        zoomPosition = zoomTarget.position;
        ZoomIn();
    }

    public void ZoomIn()
    {
        ZoomActive = true;
        zoomStartTime = Time.time;

        //activas musica zoom
        AudioManagerCirculos.instance.PlaySFX("zoom");
    }

    public void ZoomOut()
    {
        ZoomActive = false;
        zoomStartTime = Time.time;
    }

    private void LateUpdate()
    {
        if (ZoomActive)
        {
            float elapsedTime = Time.time - zoomStartTime;
            float t = Mathf.Clamp01(elapsedTime / zoomDuration);

            // Calcula la posici�n y el tama�o ortogr�fico en funci�n del tiempo
            Vector3 lerpedPosition = Vector3.Lerp(originalPosition, zoomPosition, t);
            float lerpedOrthographicSize = Mathf.Lerp(originalOrthographicSize, zoomOrthographicSize, t);

            // Aplica la posici�n y el tama�o ortogr�fico a la c�mara
            cam.transform.position = new Vector3(lerpedPosition.x, lerpedPosition.y, cam.transform.position.z);
            cam.orthographicSize = lerpedOrthographicSize;
            Invoke("ActivarBoton", 2f);
        }
    }

    public void ActivarBoton()
    {
        boton.SetActive(true);
    }

    public void PasarEscenaJuego()
    {

        SceneManager.LoadScene("circulosNave");
    }
}