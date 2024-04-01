using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerCaras : MonoBehaviour
{
    #region Zoom
    public float smoothSpeed; // Velocidad de suavizado

    public float targetX ; // Coordenada X del punto de enfoque
    public float targetY; // Coordenada Y del punto de enfoque
    public float targetZoom; // Tamaño de zoom deseado

    #endregion

    private Camera mainCamera;

    #region Tandas
    [Header("Tandas")]
    [SerializeField]
    private GameObject tanda1;
    [SerializeField]
    private GameObject tanda2;
    [SerializeField]
    private GameObject tanda3;
    [SerializeField]
    private GameObject tanda4;
    [SerializeField]
    private GameObject tanda5;
    [SerializeField]
    private GameObject tanda6;
    [SerializeField]
    private GameObject tanda7;
    [SerializeField]
    private GameObject tanda8;
    [SerializeField]
    private GameObject tanda9;
    [SerializeField]
    private GameObject tanda10;
    #endregion

    #region Tanda1
    [Header("Tanda 1 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto1;
    [SerializeField]
    private GameObject marco1;

    [SerializeField]
    private GameObject botonRespuesta1;
    [SerializeField]
    private GameObject botonRespuesta2;
    [SerializeField]
    private GameObject botonRespuesta3;
    [SerializeField]
    private GameObject botonRespuesta4;
    

    private bool stopTanda1 = false;

    //[SerializeField]
    //private GameObject botonContinue;

    [SerializeField]
    private GameObject dialoguePanel1;
    #endregion

    #region Tanda2
    [Header("Tanda 2 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto2;
    [SerializeField]
    private GameObject marco2;

    [SerializeField]
    private GameObject botonRespuesta21;
    [SerializeField]
    private GameObject botonRespuesta22;
    [SerializeField]
    private GameObject botonRespuesta23;
    [SerializeField]
    private GameObject botonRespuesta24;

    //[SerializeField]
    //private GameObject botonContinue2;

    [SerializeField]
    private GameObject dialoguePanel2;
    #endregion

    #region Tanda3
    [Header("Tanda 3 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto3;
    [SerializeField]
    private GameObject marco3;

    [SerializeField]
    private GameObject botonRespuesta31;
    [SerializeField]
    private GameObject botonRespuesta32;
    [SerializeField]
    private GameObject botonRespuesta33;
    [SerializeField]
    private GameObject botonRespuesta34;

    //[SerializeField]
    //private GameObject botonContinue3;

    [SerializeField]
    private GameObject dialoguePanel3;
    #endregion

    #region Tanda4
    [Header("Tanda 4 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto4;
    [SerializeField]
    private GameObject marco4;

    [SerializeField]
    private GameObject botonRespuesta41;
    [SerializeField]
    private GameObject botonRespuesta42;
    [SerializeField]
    private GameObject botonRespuesta43;
    [SerializeField]
    private GameObject botonRespuesta44;

    //[SerializeField]
    //private GameObject botonContinue3;

    [SerializeField]
    private GameObject dialoguePanel4;
    #endregion

    #region Tanda5
    [Header("Tanda 5 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto5;
    [SerializeField]
    private GameObject marco5;

    [SerializeField]
    private GameObject botonRespuesta51;
    [SerializeField]
    private GameObject botonRespuesta52;
    [SerializeField]
    private GameObject botonRespuesta53;
    [SerializeField]
    private GameObject botonRespuesta54;

    //[SerializeField]
    //private GameObject botonContinue3;

    [SerializeField]
    private GameObject dialoguePanel5;
    #endregion

    #region Tanda6
    [Header("Tanda 6 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto6;
    [SerializeField]
    private GameObject marco6;

    [SerializeField]
    private GameObject botonRespuesta61;
    [SerializeField]
    private GameObject botonRespuesta62;
    [SerializeField]
    private GameObject botonRespuesta63;
    [SerializeField]
    private GameObject botonRespuesta64;

    //[SerializeField]
    //private GameObject botonContinue3;

    [SerializeField]
    private GameObject dialoguePanel6;
    #endregion

    #region Tanda7
    [Header("Tanda 7 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto7;
    [SerializeField]
    private GameObject marco7;

    [SerializeField]
    private GameObject botonRespuesta71;
    [SerializeField]
    private GameObject botonRespuesta72;
    [SerializeField]
    private GameObject botonRespuesta73;
    [SerializeField]
    private GameObject botonRespuesta74;

    //[SerializeField]
    //private GameObject botonContinue3;

    [SerializeField]
    private GameObject dialoguePanel7;
    #endregion

    #region Tanda8
    [Header("Tanda 8 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto8;
    [SerializeField]
    private GameObject marco8;

    [SerializeField]
    private GameObject botonRespuesta81;
    [SerializeField]
    private GameObject botonRespuesta82;
    [SerializeField]
    private GameObject botonRespuesta83;
    [SerializeField]
    private GameObject botonRespuesta84;

    //[SerializeField]
    //private GameObject botonContinue3;

    [SerializeField]
    private GameObject dialoguePanel8;
    #endregion

    #region Tanda9
    [Header("Tanda 9 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto9;
    [SerializeField]
    private GameObject marco9;

    [SerializeField]
    private GameObject botonRespuesta91;
    [SerializeField]
    private GameObject botonRespuesta92;
    [SerializeField]
    private GameObject botonRespuesta93;
    [SerializeField]
    private GameObject botonRespuesta94;

    //[SerializeField]
    //private GameObject botonContinue3;

    [SerializeField]
    private GameObject dialoguePanel9;
    #endregion

    #region Tanda10
    [Header("Tanda 10 - Foto, respuestas y diálogo")]
    [SerializeField]
    private GameObject foto10;
    [SerializeField]
    private GameObject marco10;

    [SerializeField]
    private GameObject botonRespuesta101;
    [SerializeField]
    private GameObject botonRespuesta102;
    [SerializeField]
    private GameObject botonRespuesta103;
    [SerializeField]
    private GameObject botonRespuesta104;

    //[SerializeField]
    //private GameObject botonContinue3;

    [SerializeField]
    private GameObject dialoguePanel10;
    #endregion

    void Start()
    {
        mainCamera = Camera.main; // Obtén la cámara principal
    }

    //PARA ZOOM INICIAL Y EFECTOS PREGUNTAS
    void Update()
    {
        // Calcula la posición objetivo para el zoom
        Vector3 targetPos = new Vector3(targetX, targetY, mainCamera.transform.position.z);

        // Usa Lerp para suavizar el movimiento de la cámara hacia la posición objetivo
        mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, targetZoom, smoothSpeed * Time.deltaTime);
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, targetPos, smoothSpeed * Time.deltaTime);

        //rango especifico de texto
        //comprobamos que es la escena tareaCaras2
        if(SceneManager.GetActiveScene().name == "tareaCaras2" && (Mathf.Abs(mainCamera.orthographicSize - (targetZoom*1.5f)) <= 0.3f)&& !stopTanda1)
        {
            //ponemos texto de pregunta
            SetTamañoPanel(dialoguePanel1, true);
        }
        //rango especifico de fotos
        //comprobamos que es la escena tareaCaras2
        if (SceneManager.GetActiveScene().name == "tareaCaras2" && (Mathf.Abs(mainCamera.orthographicSize - targetZoom) <= 1f) &&!stopTanda1)
        {
            SetIniciarTanda1(true);
            stopTanda1 = true;
        }
    }


    //poner tanda 1
    #region Tanda1
    public void SetIniciarTanda1(bool set)
    {
        //activamos tanda1
        SetTandaChosen(true, false, false, false, false, false, false, false, false, false);
        //quitamos dialoguePanel1
        SetTamañoPanel(dialoguePanel1, true);
        //ponemos imagen  ajustamos tamaño 
        SetImagenBigSize(foto1);
        //ajustamos marco
        //SetMarcoBigSize(marco1);
        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta1, botonRespuesta2, botonRespuesta3, botonRespuesta4, true);
    }

    #endregion

    //poner tanda 2
    #region Tanda2
    public void SetIniciarTanda2(bool set)
    {
    

        //activamos tanda 2
        SetTandaChosen(false,true, false, false, false, false, false, false, false, false);

        //quitamos dialoguePanel1
        SetTamañoPanel(dialoguePanel1, false);
        //ponemos dialoguePanel2  a grande
        SetTamañoPanel(dialoguePanel2, true);
        //activamos dialogo 2
        SetDialoguePanel(false, true, false, false, false, false, false, false, false, false);

        //poner imagen 2 a grande
        SetImagenBigSize(foto2);
        //ajustamos marco
        //SetMarcoBigSize(marco2);

        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta21, botonRespuesta22, botonRespuesta23, botonRespuesta24, true);
    }

    #endregion

    //poner tanda 3
    #region Tanda3
    public void SetIniciarTanda3(bool set)
    {

        //activamos tanda3
        SetTandaChosen(false, false, true, false, false, false, false, false, false, false);

        //quitamos dialoguePanel2
        SetTamañoPanel(dialoguePanel2, false);
        //ponemos dialoguePanel3
        SetTamañoPanel(dialoguePanel3, true);
        //activamos dialogo3
        SetDialoguePanel(false, false, true, false, false, false, false,false, false, false);

        //ponemos imagen  ajustamos tamaño 
        SetImagenBigSize(foto3);
        //ajustamos marco
        //SetMarcoBigSize(marco3);
        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta31, botonRespuesta32, botonRespuesta33, botonRespuesta34, true);
    }

    #endregion

    //poner tanda 4
    #region Tanda4
    public void SetIniciarTanda4(bool set)
    {

        //activamos tanda4
        SetTandaChosen(false, false, false, true, false, false, false, false, false, false);

        //quitamos dialoguePanel3
        SetTamañoPanel(dialoguePanel3, false);
        //ponemos dialoguePanel4
        SetTamañoPanel(dialoguePanel4, true);
        //activamos dialogo4
        SetDialoguePanel(false, false, false, true, false, false, false, false, false, false);

        //ponemos imagen  ajustamos tamaño 
        SetImagenBigSize(foto4);
        //ajustamos marco
        //SetMarcoBigSize(marco4);
        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta41, botonRespuesta42, botonRespuesta43, botonRespuesta44, true);
    }

    #endregion

    //poner tanda 5
    #region Tanda5
    public void SetIniciarTanda5(bool set)
    {

        //activamos tanda5
        SetTandaChosen(false, false, false, false, true, false, false, false, false, false);

        //quitamos dialoguePanel4
        SetTamañoPanel(dialoguePanel4, false);
        //ponemos dialoguePanel5
        SetTamañoPanel(dialoguePanel5, true);
        //activamos dialogo5
        SetDialoguePanel(false, false, false, false, true, false, false, false, false, false);

        //ponemos imagen  ajustamos tamaño 
        SetImagenBigSize(foto5);
        //ajustamos marco
        //SetMarcoBigSize(marco5);
        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta51, botonRespuesta52, botonRespuesta53, botonRespuesta54, true);
    }

    #endregion

    //poner tanda 6
    #region Tanda6
    public void SetIniciarTanda6(bool set)
    {

        //activamos tanda6
        SetTandaChosen(false, false, false, false, false, true, false, false, false, false);

        //quitamos dialoguePanel5
        SetTamañoPanel(dialoguePanel5, false);
        //ponemos dialoguePanel6
        SetTamañoPanel(dialoguePanel6, true);
        //activamos dialogo6
        SetDialoguePanel(false, false, false, false, false, true, false, false, false, false);

        //ponemos imagen  ajustamos tamaño 
        SetImagenBigSize(foto6);
        //ajustamos marco
        //SetMarcoBigSize(marco6);

        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta61, botonRespuesta62, botonRespuesta63, botonRespuesta64, true);
    }

    #endregion

    //poner tanda 7
    #region Tanda7
    public void SetIniciarTanda7(bool set)
    {

        //activamos tanda7
        SetTandaChosen(false, false, false, false, false, false, true, false, false, false);

        //quitamos dialoguePanel6
        SetTamañoPanel(dialoguePanel6, false);
        //ponemos dialoguePanel7
        SetTamañoPanel(dialoguePanel7, true);
        //activamos dialogo7
        SetDialoguePanel(false, false, false, false, false,false,true, false, false, false);

        //ponemos imagen  ajustamos tamaño 
        SetImagenBigSize(foto7);
        //ajustamos marco
        //SetMarcoBigSize(marco7);

        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta71, botonRespuesta72, botonRespuesta73, botonRespuesta74, true);
    }

    #endregion

    //poner tanda 8
    #region Tanda8
    public void SetIniciarTanda8(bool set)
    {

        //activamos tanda8
        SetTandaChosen(false, false, false, false, false, false, false, true, false, false);

        //quitamos dialoguePanel7
        SetTamañoPanel(dialoguePanel7, false);
        //ponemos dialoguePanel8
        SetTamañoPanel(dialoguePanel8, true);
        //activamos dialogo8
        SetDialoguePanel(false, false, false, false, false, false, false, true, false, false);

        //ponemos imagen  ajustamos tamaño 
        SetImagenBigSize(foto8);
        //ajustamos marco
        //SetMarcoBigSize(marco8);

        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta81, botonRespuesta82, botonRespuesta83, botonRespuesta84, true);
    }

    #endregion

    //poner tanda 9
    #region Tanda9
    public void SetIniciarTanda9(bool set)
    {

        //activamos tanda9
        SetTandaChosen(false, false, false, false, false, false, false, false, true, false);

        //quitamos dialoguePanel8
        SetTamañoPanel(dialoguePanel8, false);
        //ponemos dialoguePanel9
        SetTamañoPanel(dialoguePanel9, true);
        //activamos dialogo9
        SetDialoguePanel(false, false, false, false, false, false, false, false, true, false);

        //ponemos imagen  ajustamos tamaño 
        SetImagenBigSize(foto9);

        //ajustamos marco
        //SetMarcoBigSize(marco9);
        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta91, botonRespuesta92, botonRespuesta93, botonRespuesta94, true);
    }

    #endregion

    //poner tanda 10
    #region Tanda10
    public void SetIniciarTanda10(bool set)
    {

        //activamos tanda10
        SetTandaChosen(false, false, false, false, false, false, false, false, false, true);

        //quitamos dialoguePanel9
        SetTamañoPanel(dialoguePanel9, false);
        //ponemos dialoguePanel10
        SetTamañoPanel(dialoguePanel10, true);
        //activamos dialogo10
        SetDialoguePanel(false, false, false, false, false, false, false, false, false, true);

        //ponemos imagen  ajustamos tamaño 
        SetImagenBigSize(foto10);
        //ajustamos marco
        //SetMarcoBigSize(marco10);
        //y botones de respuesta
        SetActiveBotonesOpciones(botonRespuesta101, botonRespuesta102, botonRespuesta103, botonRespuesta104, true);
    }

    #endregion

    //efecto Imagen
    private void SetImagenBigSize(GameObject foto)
    {
        foto.SetActive(true);
        foto.transform.DOScale(new Vector3(0.012f, 0.012f, 0.012f), 1f);
    }


    //efecto marco
    private void SetMarcoBigSize(GameObject foto)
    {
        foto.SetActive(true);
        foto.transform.DOScale(new Vector3(0.01f, 0.01f, 0.01f), 1f);
    }
    //set de seguridad para poner tanda correcta solo
    private void SetTandaChosen(bool setTanda1, bool setTanda2, bool setTanda3, bool setTanda4, bool setTanda5, bool setTanda6, bool setTanda7, bool setTanda8, bool setTanda9, bool setTanda10)
    {
        //comprobacion extra
        tanda1.SetActive(setTanda1);
        tanda2.SetActive(setTanda2);
        tanda3.SetActive(setTanda3);
        tanda4.SetActive(setTanda4);
        tanda5.SetActive(setTanda5);
        tanda6.SetActive(setTanda6);
        tanda7.SetActive(setTanda7);
        tanda8.SetActive(setTanda8);
        tanda9.SetActive(setTanda9);
        tanda10.SetActive(setTanda10);
    }

    //para poner panel pequeño o grande
    private void SetTamañoPanel(GameObject dialoguePanel, bool set)
    {
        dialoguePanel.SetActive(set);
        //si lo quieres hacer grande
        if (set)
        {
            
            dialoguePanel.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 1f);
        }
        else
        {
            dialoguePanel.transform.DOScale(new Vector3(0.001f, 0.001f, 0.001f), 1f);
        }

    }

    //activar botones opciones de la tanda que sea
    private void SetActiveBotonesOpciones(GameObject boton1, GameObject boton2, GameObject boton3, GameObject boton4, bool set)
    {
        boton1.SetActive(set);
        boton2.SetActive(set);
        boton3.SetActive(set);
        boton4.SetActive(set);
    }

    //set de seguridad para activar el panel de dialogo que sea
    private void SetDialoguePanel(bool setTanda1, bool setTanda2, bool setTanda3, bool setTanda4, bool setTanda5, bool setTanda6, bool setTanda7, bool setTanda8, bool setTanda9, bool setTanda10)
    {
        dialoguePanel1.SetActive(setTanda1);
        dialoguePanel2.SetActive(setTanda2);
        dialoguePanel3.SetActive(setTanda3);
        dialoguePanel4.SetActive(setTanda4);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("escenaConversacionRobot3");
        //SceneManager.LoadScene("BengalasPrueba");
    }
}