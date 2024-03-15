using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerTareaCaras : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    static private ManagerTareaCaras _instanceTareaCaras;
    static public ManagerTareaCaras GetInstanceManagerTareaCaras()
    {
        return _instanceTareaCaras;
    }

    private void Start()
    {
        //conectamos con manager caras
       _instanceItems = InfoItemsSecuenciasMongoDB.GetIstanceInfoItemsSecuenciasMongoDB();
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

    #region TestsCaras
    [SerializeField]
    private GameObject test1Caras;

    [SerializeField]
    private GameObject test2Caras;

    [SerializeField]
    private GameObject test3Caras;

    [SerializeField]
    private GameObject test4Caras;

    [SerializeField]
    private GameObject test5Caras;

    [SerializeField]
    private GameObject test6Caras;

    [SerializeField]
    private GameObject test7Caras;

    [SerializeField]
    private GameObject test8Caras;

    [SerializeField]
    private GameObject test9Caras;

    [SerializeField]
    private GameObject test10Caras;
    #endregion







    #region argumentos Tanda1TareaCaras

    private string resultadoPruebaCaras1 = "";

        private int resultadoNumPruebaCaras1 = 0;

    #endregion
    #region campos tanda1 caras

        private string itemNameCaras_1 = "EI_1";

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
    private string itemNameCaras_2 = "EI_2";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_2;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type2 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_2;
    //numero de segundos por partida
    private int numSecsPartidaCaras2 = 0;
    #endregion


    #region argumentos Tanda3Caras
    private string resultadoPruebaCaras3 = "";
    private int resultadoNumPruebaCaras3 = 0;
    #endregion
    #region camposTanda3Caras
    private string itemNameCaras_3 = "EI_3";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_3;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type3 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_3;
    //numero de segundos por partida
    private int numSecsPartidaCaras3 = 0;
    #endregion


    #region argumentos Tanda4Caras
    private string resultadoPruebaCaras4 = "";
    private int resultadoNumPruebaCaras4 = 0;
    #endregion
    #region camposTanda4Caras
    private string itemNameCaras_4 = "EI_4";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_4;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type4 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_4;
    //numero de segundos por partida
    private int numSecsPartidaCaras4 = 0;
    #endregion


    #region argumentos Tanda5Caras
    private string resultadoPruebaCaras5 = "";
    private int resultadoNumPruebaCaras5 = 0;
    #endregion
    #region camposTanda5Caras
    private string itemNameCaras_5 = "EI_5";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_5;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type5 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_5;
    //numero de segundos por partida
    private int numSecsPartidaCaras5 = 0;
    #endregion


    #region argumentos Tanda6Caras
    private string resultadoPruebaCaras6 = "";
    private int resultadoNumPruebaCaras6 = 0;
    #endregion
    #region camposTanda6Caras
    private string itemNameCaras_6 = "EI_6";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_6;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type6 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_6;
    //numero de segundos por partida
    private int numSecsPartidaCaras6 = 0;
    #endregion


    #region argumentos Tanda7Caras
    private string resultadoPruebaCaras7 = "";
    private int resultadoNumPruebaCaras7 = 0;
    #endregion
    #region camposTanda7Caras
    private string itemNameCaras_7 = "EI_7";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_7;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type7 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_7;
    //numero de segundos por partida
    private int numSecsPartidaCaras7 = 0;
    #endregion


    #region argumentos Tanda8Caras
    private string resultadoPruebaCaras8 = "";
    private int resultadoNumPruebaCaras8 = 0;
    #endregion
    #region camposTanda8Caras
    private string itemNameCaras_8 = "EI_8";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_8;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type8 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_8;
    //numero de segundos por partida
    private int numSecsPartidaCaras8 = 0;
    #endregion


    #region argumentos Tanda9Caras
    private string resultadoPruebaCaras9 = "";
    private int resultadoNumPruebaCaras9 = 0;
    #endregion
    #region camposTanda9Caras
    private string itemNameCaras_9 = "EI_9";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_9;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type9 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_9;
    //numero de segundos por partida
    private int numSecsPartidaCaras9 = 0;
    #endregion


    #region argumentos Tanda10Caras
    private string resultadoPruebaCaras10 = "";
    private int resultadoNumPruebaCaras10 = 0;
    #endregion
    #region camposTanda10Caras
    private string itemNameCaras_10 = "EI_10";
    //cantidad de softskills que mide y nombres
    private string[] softSkillCaras_10;
    //tipo de test que es, si imagenes, preguntas escritas, etc
    private int type10 = 2;
    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionCaras_10;
    //numero de segundos por partida
    private int numSecsPartidaCaras10 = 0;
    #endregion











    #region methods Caras1

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras1()
    {
        resultadoPruebaCaras1 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras1 = 0;
        //enviamos respuesta
        SetCaras1();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras1()
    {
        resultadoPruebaCaras1 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras1 = 0;
        //enviamos respuesta
        SetCaras1();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCaras1()
    {
        resultadoPruebaCaras1 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras1 = 10;
        //enviamos respuesta
        SetCaras1();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCaras1()
    {
        resultadoPruebaCaras1 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras1 = 0;
        //enviamos respuesta
        SetCaras1();
    }

    //para pasar a siguiente test
    public void SetCaras1()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_1();
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
        //enviamos respuesta
        SetCaras2();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras2()
    {
        resultadoPruebaCaras2 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras2 = 0;
        //enviamos respuesta
        SetCaras2();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa2()
    {
        resultadoPruebaCaras2 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras2 = 0;
        //enviamos respuesta
        SetCaras2();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCarasa2()
    {
        resultadoPruebaCaras2 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras2 = 10;
        //enviamos respuesta
        SetCaras2();
    }

    //para pasar a siguiente test
    public void SetCaras2()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_2();
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


    #region methods Caras3
    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras3()
    {
        resultadoPruebaCaras3 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras3 = 0;
        //enviamos respuesta
        SetCaras3();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras3()
    {
        resultadoPruebaCaras3 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras3 = 10;
        //enviamos respuesta
        SetCaras3();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa3()
    {
        resultadoPruebaCaras3 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras3= 0;
        //enviamos respuesta
        SetCaras3();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCarasa3()
    {
        resultadoPruebaCaras3 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras3 = 0;
        //enviamos respuesta
        SetCaras3();
    }

    //para pasar a siguiente test
    public void SetCaras3()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_3();
    }

    public int TiempoPartidaCaras3()
    {
        numSecsPartidaCaras3 = 0;
        return numSecsPartidaCaras3;
    }
    #endregion
    #region ArgumentosCaras3

    public string itemNameCARAS_3()
    {
        return itemNameCaras_3;
    }

    public string[] softskillCARAS_3()
    {
        softSkillCaras_3 = new string[1];
        softSkillCaras_3[0] = "confianza";
        return softSkillCaras_3;
    }

    public int typeCARAS_3()
    {

        return type3;
    }

    public float[] puntuacionCARAS_3()
    {
        puntuacionCaras_3 = new float[1];
        puntuacionCaras_3[0] = resultadoNumPruebaCaras3;
        return puntuacionCaras_3;
    }


    #endregion


    #region methods Caras4
    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras4()
    {
        resultadoPruebaCaras4 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras4 = 10;
        //enviamos respuesta
        SetCaras4();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras4()
    {
        resultadoPruebaCaras4 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras4 = 0;
        //enviamos respuesta
        SetCaras4();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa4()
    {
        resultadoPruebaCaras4 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras4 = 0;
        //enviamos respuesta
        SetCaras4();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCarasa4()
    {
        resultadoPruebaCaras4 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras4 = 0;
        //enviamos respuesta
        SetCaras4();
    }

    //para pasar a siguiente test
    public void SetCaras4()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_4();
    }

    public int TiempoPartidaCaras4()
    {
        numSecsPartidaCaras4 = 0;
        return numSecsPartidaCaras4;
    }
    #endregion
    #region ArgumentosCaras4

    public string itemNameCARAS_4()
    {
        return itemNameCaras_4;
    }

    public string[] softskillCARAS_4()
    {
        softSkillCaras_4 = new string[1];
        softSkillCaras_4[0] = "confianza";
        return softSkillCaras_4;
    }

    public int typeCARAS_4()
    {

        return type4;
    }

    public float[] puntuacionCARAS_4()
    {
        puntuacionCaras_4 = new float[1];
        puntuacionCaras_4[0] = resultadoNumPruebaCaras4;
        return puntuacionCaras_4;
    }


    #endregion


    #region methods Caras5
    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras5()
    {
        resultadoPruebaCaras5 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras5 = 0;
        //enviamos respuesta
        SetCaras5();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras5()
    {
        resultadoPruebaCaras5 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras5 = 0;
        //enviamos respuesta
        SetCaras5();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa5()
    {
        resultadoPruebaCaras5 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras5 = 0;
        //enviamos respuesta
        SetCaras5();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCarasa5()
    {
        resultadoPruebaCaras5 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras5 = 10;
        //enviamos respuesta
        SetCaras5();
    }

    //para pasar a siguiente test
    public void SetCaras5()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_5();
    }

    public int TiempoPartidaCaras5()
    {
        numSecsPartidaCaras5 = 0;
        return numSecsPartidaCaras5;
    }
    #endregion
    #region ArgumentosCaras5

    public string itemNameCARAS_5()
    {
        return itemNameCaras_5;
    }

    public string[] softskillCARAS_5()
    {
        softSkillCaras_5 = new string[1];
        softSkillCaras_5[0] = "confianza";
        return softSkillCaras_5;
    }

    public int typeCARAS_5()
    {

        return type5;
    }

    public float[] puntuacionCARAS_5()
    {
        puntuacionCaras_5 = new float[1];
        puntuacionCaras_5[0] = resultadoNumPruebaCaras5;
        return puntuacionCaras_5;
    }


    #endregion


    #region methods Caras6
    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras6()
    {
        resultadoPruebaCaras6 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras6 = 10;
        //enviamos respuesta
        SetCaras6();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras6()
    {
        resultadoPruebaCaras6 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras6 = 0;
        //enviamos respuesta
        SetCaras6();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa6()
    {
        resultadoPruebaCaras6 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras6 = 0;
        //enviamos respuesta
        SetCaras6();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCarasa6()
    {
        resultadoPruebaCaras6 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras6 = 0;
        //enviamos respuesta
        SetCaras6();
    }

    //para pasar a siguiente test
    public void SetCaras6()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_6();
    }

    public int TiempoPartidaCaras6()
    {
        numSecsPartidaCaras6 = 0;
        return numSecsPartidaCaras6;
    }
    #endregion
    #region ArgumentosCaras6

    public string itemNameCARAS_6()
    {
        return itemNameCaras_6;
    }

    public string[] softskillCARAS_6()
    {
        softSkillCaras_6 = new string[1];
        softSkillCaras_6[0] = "confianza";
        return softSkillCaras_6;
    }

    public int typeCARAS_6()
    {

        return type6;
    }

    public float[] puntuacionCARAS_6()
    {
        puntuacionCaras_6 = new float[1];
        puntuacionCaras_6[0] = resultadoNumPruebaCaras6;
        return puntuacionCaras_6;
    }


    #endregion


    #region methods Caras7
    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras7()
    {
        resultadoPruebaCaras7 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras7 = 0;
        //enviamos respuesta
        SetCaras7();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras7()
    {
        resultadoPruebaCaras7 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras7 = 0;
        //enviamos respuesta
        SetCaras7();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa7()
    {
        resultadoPruebaCaras7 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras7 = 10;
        //enviamos respuesta
        SetCaras7();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCarasa7()
    {
        resultadoPruebaCaras7 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras7 = 0;
        //enviamos respuesta
        SetCaras7();
    }

    //para pasar a siguiente test
    public void SetCaras7()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_7();
    }

    public int TiempoPartidaCaras7()
    {
        numSecsPartidaCaras7 = 0;
        return numSecsPartidaCaras7;
    }
    #endregion
    #region ArgumentosCaras7

    public string itemNameCARAS_7()
    {
        return itemNameCaras_7;
    }

    public string[] softskillCARAS_7()
    {
        softSkillCaras_7 = new string[1];
        softSkillCaras_7[0] = "confianza";
        return softSkillCaras_7;
    }

    public int typeCARAS_7()
    {

        return type7;
    }

    public float[] puntuacionCARAS_7()
    {
        puntuacionCaras_7 = new float[1];
        puntuacionCaras_7[0] = resultadoNumPruebaCaras7;
        return puntuacionCaras_7;
    }


    #endregion


    #region methods Caras8
    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras8()
    {
        resultadoPruebaCaras8 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras8 = 0;
        //enviamos respuesta
        SetCaras8();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras8()
    {
        resultadoPruebaCaras8 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras8 = 10;
        //enviamos respuesta
        SetCaras8();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa8()
    {
        resultadoPruebaCaras8 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras8 = 0;
        //enviamos respuesta
        SetCaras8();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCarasa8()
    {
        resultadoPruebaCaras8 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras8 = 0;
        //enviamos respuesta
        SetCaras8();
    }

    //para pasar a siguiente test
    public void SetCaras8()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_8();
    }

    public int TiempoPartidaCaras8()
    {
        numSecsPartidaCaras8 = 0;
        return numSecsPartidaCaras8;
    }
    #endregion
    #region ArgumentosCaras8

    public string itemNameCARAS_8()
    {
        return itemNameCaras_8;
    }

    public string[] softskillCARAS_8()
    {
        softSkillCaras_8 = new string[1];
        softSkillCaras_8[0] = "confianza";
        return softSkillCaras_8;
    }

    public int typeCARAS_8()
    {

        return type8;
    }

    public float[] puntuacionCARAS_8()
    {
        puntuacionCaras_8 = new float[1];
        puntuacionCaras_8[0] = resultadoNumPruebaCaras8;
        return puntuacionCaras_8;
    }


    #endregion


    #region methods Caras9
    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras9()
    {
        resultadoPruebaCaras9 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras9 = 0;
        //enviamos respuesta
        SetCaras9();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras9()
    {
        resultadoPruebaCaras9 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras9 = 0;
        //enviamos respuesta
        SetCaras9();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa9()
    {
        resultadoPruebaCaras9 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras9 = 0;
        //enviamos respuesta
        SetCaras9();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCarasa9()
    {
        resultadoPruebaCaras9= "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras9 = 10;
        //enviamos respuesta
        SetCaras9();
    }

    //para pasar a siguiente test
    public void SetCaras9()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_9();
    }

    public int TiempoPartidaCaras9()
    {
        numSecsPartidaCaras9 = 0;
        return numSecsPartidaCaras9;
    }
    #endregion
    #region ArgumentosCaras9

    public string itemNameCARAS_9()
    {
        return itemNameCaras_9;
    }

    public string[] softskillCARAS_9()
    {
        softSkillCaras_9 = new string[1];
        softSkillCaras_9[0] = "confianza";
        return softSkillCaras_9;
    }

    public int typeCARAS_9()
    {

        return type9;
    }

    public float[] puntuacionCARAS_9()
    {
        puntuacionCaras_9 = new float[1];
        puntuacionCaras_9[0] = resultadoNumPruebaCaras9;
        return puntuacionCaras_9;
    }


    #endregion


    #region methods Caras10
    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionACaras10()
    {
        resultadoPruebaCaras10 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras10 = 10;
        //enviamos respuesta
        SetCaras10();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBCaras10()
    {
        resultadoPruebaCaras10 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras10 = 0;
        //enviamos respuesta
        SetCaras10();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCCarasa10()
    {
        resultadoPruebaCaras10 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras10 = 0;
        //enviamos respuesta
        SetCaras10();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDCarasa10()
    {
        resultadoPruebaCaras10 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaCaras10 = 0;
        //enviamos respuesta
        SetCaras10();
    }

    //para pasar a siguiente test
    public void SetCaras10()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosCARAS_10();
    }

    public int TiempoPartidaCaras10()
    {
        numSecsPartidaCaras10 = 0;
        return numSecsPartidaCaras10;
    }
    #endregion
    #region ArgumentosCaras10

    public string itemNameCARAS_10()
    {
        return itemNameCaras_10;
    }

    public string[] softskillCARAS_10()
    {
        softSkillCaras_10 = new string[1];
        softSkillCaras_10[0] = "confianza";
        return softSkillCaras_10;
    }

    public int typeCARAS_10()
    {

        return type10;
    }

    public float[] puntuacionCARAS_10()
    {
        puntuacionCaras_10 = new float[1];
        puntuacionCaras_10[0] = resultadoNumPruebaCaras10;
        return puntuacionCaras_10;
    }


    #endregion
}
