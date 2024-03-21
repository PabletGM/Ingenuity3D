using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerItemsSecuencia4 : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    static private ManagerItemsSecuencia4 _instanceItemsSecuencia4;
    static public ManagerItemsSecuencia4 GetInstanceManagerItemsSecuencia4()
    {
        return _instanceItemsSecuencia4;
    }



    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceItemsSecuencia4 == null)
        {
            _instanceItemsSecuencia4 = this;
        }
        //si la instancia existe , destruimos la copia
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        //conectamos con manager caras
        _instanceItems = InfoItemsSecuenciasMongoDB.GetIstanceInfoItemsSecuenciasMongoDB();
    }


    #region argumentos Tanda1ItemsSecuencia4

    private string resultadoPruebaItemsSecuencia4 = "";

    private int resultadoNumPruebaItemsSecuencia4 = 0;

    #endregion
    #region campos tanda1 ItemsSecuencia4

    private string itemNameItemsSecuencia4 = "EQUI_1";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia4;

    //tipo de test que es, en este caso las caras es type 2
    private int type = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia4;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia4 = 0;

    #endregion

    #region argumentos Tanda2ItemsSecuencia4

    private string resultadoPruebaItemsSecuencia42 = "";

    private int resultadoNumPruebaItemsSecuencia42 = 0;

    #endregion
    #region campos tanda2 ItemsSecuencia4

    private string itemNameItemsSecuencia42 = "IN_3";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia42;

    //tipo de test que es, en este caso las caras es type 2
    private int type2 = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia42;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia42 = 0;

    #endregion

    #region argumentos Tanda3ItemsSecuencia4

    private string resultadoPruebaItemsSecuencia43 = "";

    private int resultadoNumPruebaItemsSecuencia43 = 0;

    #endregion
    #region campos tanda3 ItemsSecuencia4

    private string itemNameItemsSecuencia43 = "RES_4";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia43;

    //tipo de test que es, en este caso las caras es type 2
    private int type3 = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia43;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia43 = 0;

    #endregion




    #region methods ItemsSecuencia4

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia4()
    {
        resultadoPruebaItemsSecuencia4 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia4 = 0;
        //enviamos respuesta
        SetItemsSecuencia4();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia4()
    {
        resultadoPruebaItemsSecuencia4 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia4 = 5;
        //enviamos respuesta
        SetItemsSecuencia4();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia4()
    {
        resultadoPruebaItemsSecuencia4 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia4 = 10;
        //enviamos respuesta
        SetItemsSecuencia4();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia4()
    {
        resultadoPruebaItemsSecuencia4 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia4 = 0;
        //enviamos respuesta
        SetItemsSecuencia4();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia4()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia4();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia4()
    {
        numSecsPartidaItemsSecuencia4 = 0;
        return numSecsPartidaItemsSecuencia4;
    }

    #endregion
    #region Argumentos1

    public string itemNameItemSecuencia4()
    {
        return itemNameItemsSecuencia4;
    }

    public string[] softskillItemsSecuencia4()
    {
        softSkillItemsSecuencia4 = new string[1];
        softSkillItemsSecuencia4[0] = "trabajoEquipo";
        return softSkillItemsSecuencia4;
    }

    public int typeItemsSecuencia4()
    {

        return type;
    }

    public float[] puntuacionItemSecuencia4()
    {
        puntuacionItemsSecuencia4 = new float[1];
        puntuacionItemsSecuencia4[0] = resultadoNumPruebaItemsSecuencia4;
        return puntuacionItemsSecuencia4;
    }


    #endregion

    #region methods ItemsSecuencia42

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia42()
    {
        resultadoPruebaItemsSecuencia42 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia42 = 0;
        //enviamos respuesta
        SetItemsSecuencia42();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia42()
    {
        resultadoPruebaItemsSecuencia42 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia42 = 5;
        //enviamos respuesta
        SetItemsSecuencia42();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia42()
    {
        resultadoPruebaItemsSecuencia42 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia42 = 10;
        //enviamos respuesta
        SetItemsSecuencia42();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia42()
    {
        resultadoPruebaItemsSecuencia42 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia42 = 0;
        //enviamos respuesta
        SetItemsSecuencia42();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia42()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia42();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia42()
    {
        numSecsPartidaItemsSecuencia42 = 0;
        return numSecsPartidaItemsSecuencia42;
    }

    #endregion
    #region Argumentos2

    public string itemNameItemSecuencia42()
    {
        return itemNameItemsSecuencia42;
    }

    public string[] softskillItemsSecuencia42()
    {
        softSkillItemsSecuencia42 = new string[1];
        softSkillItemsSecuencia42[0] = "iniciativa";
        return softSkillItemsSecuencia42;
    }

    public int typeItemsSecuencia42()
    {

        return type2;
    }

    public float[] puntuacionItemSecuencia42()
    {
        puntuacionItemsSecuencia42 = new float[1];
        puntuacionItemsSecuencia42[0] = resultadoNumPruebaItemsSecuencia42;
        return puntuacionItemsSecuencia42;
    }


    #endregion

    #region methods ItemsSecuencia43

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia43()
    {
        resultadoPruebaItemsSecuencia43 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia43 = 0;
        //enviamos respuesta
        SetItemsSecuencia43();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia43()
    {
        resultadoPruebaItemsSecuencia43 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia43 = 5;
        //enviamos respuesta
        SetItemsSecuencia43();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia43()
    {
        resultadoPruebaItemsSecuencia43 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia43 = 10;
        //enviamos respuesta
        SetItemsSecuencia43();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia43()
    {
        resultadoPruebaItemsSecuencia43 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia43 = 0;
        //enviamos respuesta
        SetItemsSecuencia43();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia43()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia43();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia43()
    {
        numSecsPartidaItemsSecuencia43 = 0;
        return numSecsPartidaItemsSecuencia43;
    }

    #endregion
    #region Argumentos2

    public string itemNameItemSecuencia43()
    {
        return itemNameItemsSecuencia43;
    }

    public string[] softskillItemsSecuencia43()
    {
        softSkillItemsSecuencia43 = new string[1];
        softSkillItemsSecuencia43[0] = "resiliencia";
        return softSkillItemsSecuencia43;
    }

    public int typeItemsSecuencia43()
    {

        return type3;
    }

    public float[] puntuacionItemSecuencia43()
    {
        puntuacionItemsSecuencia43 = new float[1];
        puntuacionItemsSecuencia43[0] = resultadoNumPruebaItemsSecuencia43;
        return puntuacionItemsSecuencia43;
    }


    #endregion
}
