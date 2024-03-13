using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerTareaCaras : MonoBehaviour
{
    static private ManagerTareaCaras _instanceTareaCaras;
    static public ManagerTareaCaras GetInstanceManagerTareaCaras()
    {
        return _instanceTareaCaras;
    }

    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceTareaCaras == null)
        {
            _instanceTareaCaras = this;
        }
        //si la instancia existe , destruimos la copia
        else
        {
            Destroy(this.gameObject);
        }
    }

    #region argumentos Tanda1TareaCaras
    
        private string resultadoPruebaCaras1 = "";

        private int resultadoNumPruebaCaras1 = 0;

    #endregion
    #region campos tanda1 caras

        private string itemNameCaras_1 = "CARAS";

        //cantidad de softskills que mide y nombres
        private string[] softSkillCaras;

        //tipo de test que es, en este caso las caras es type 2
        private int type = 2;

        //cantidad de puntuaciones de todas las softskills que recoge
        private float[] puntuacionCaras1;
        //numero de segundos por partida
        private int numSecsPartidaCaras1 = 0;

    #endregion



    #region argumentos Tanda2Caras
        private string resultadoPruebaCaras2 = "";
        private int resultadoNumPruebaCaras2 = 0;
    #endregion
    #region camposTanda2Caras
    private string itemNameCaras_2 = "CARAS_2";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_2;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type2 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_2;
    //numero de segundos por partida
    private int numSecsPartidaCaras2 = 0;
    #endregion

   


    #region TestsCaras
    [SerializeField]
    private GameObject test1Caras;

    [SerializeField]
    private GameObject test2Caras;
    #endregion





    #region methods Caras1

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras1()
    {
        resultadoPruebaCaras1 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras1 = 0;

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras1()
    {
        resultadoPruebaCaras1 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras1 = 5;
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCaras1()
    {
        resultadoPruebaCaras1 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras1 = 10;
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCaras1()
    {
        resultadoPruebaCaras1 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras1 = 10;
    }

    //para pasar a siguiente test
    public void SetCaras1()
    {
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaCaras1()
    {
        numSecsPartidaCaras1 = 0;
        return numSecsPartidaCaras1; 
    }

    #endregion

    #region ArgumentosCaras1

    public string itemNameCARAS_1()
    {
        return itemNameCaras_1;
    }

    public string[] softskillCARAS_1()
    {
        softSkillCaras = new string[1];
        softSkillCaras[0] = "caras";
        return softSkillCaras;
    }

    public int typeCARAS_1()
    {

        return type;
    }

    public float[] puntuacionCARAS_1()
    {
        puntuacionCaras1 = new float[1];
        puntuacionCaras1[0] = resultadoNumPruebaCaras1;
        return puntuacionCaras1;
    }


    #endregion



    #region methods Caras2
    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras2()
    {
        resultadoPruebaCaras2 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras2 = 0;

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras2()
    {
        resultadoPruebaCaras2 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras2 = 5;
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa2()
    {
        resultadoPruebaCaras2 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras2 = 10;
    }

    //para pasar a siguiente test
    public void SetCaras2()
    {
        
    }

    public int TiempoPartidaCaras2()
    {
        numSecsPartidaCaras2 = 0;
        return numSecsPartidaCaras2;
    }
    #endregion

    #region ArgumentosCaras2

    public string itemNameCARAS_2()
    {
        return itemNameCaras_2;
    }

    public string[] softskillCARAS_2()
    {
        softSkillCaras_2 = new string[1];
        softSkillCaras_2[0] = "confianza";
        return softSkillCaras_2;
    }

    public int typeCARAS_2()
    {

        return type2;
    }

    public float[] puntuacionCARAS_2()
    {
        puntuacionCaras_2 = new float[1];
        puntuacionCaras_2[0] = resultadoNumPruebaCaras2;
        return puntuacionCaras_2;
    }


    #endregion
}
