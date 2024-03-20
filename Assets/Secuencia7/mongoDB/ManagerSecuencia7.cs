using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSecuencia7 : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    static private ManagerSecuencia7 _instanceItemsSecuencia7;
    static public ManagerSecuencia7 GetInstanceManagerItemsSecuencia7()
    {
        return _instanceItemsSecuencia7;
    }



    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceItemsSecuencia7 == null)
        {
            _instanceItemsSecuencia7 = this;
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


    #region argumentos Tanda1ItemsSecuencia7

    private string resultadoPruebaItemsSecuencia7 = "";

    private int resultadoNumPruebaItemsSecuencia7 = 0;

    #endregion
    #region campos tanda1 ItemsSecuencia7

    private string itemNameItemsSecuencia7 = "RES_5";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia7;

    //tipo de test que es, en este caso las caras es type 2
    private int type = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia7;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia7 = 0;

    #endregion

    #region argumentos Tanda2ItemsSecuencia7

    private string resultadoPruebaItemsSecuencia72 = "";

    private int resultadoNumPruebaItemsSecuencia72 = 0;

    #endregion
    #region campos tanda2 ItemsSecuencia7

    private string itemNameItemsSecuencia72 = "EQUI_2";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia72;

    //tipo de test que es, en este caso las caras es type 2
    private int type2 = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia72;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia72 = 0;

    #endregion

    #region argumentos Tanda3ItemsSecuencia7

    private string resultadoPruebaItemsSecuencia73 = "";

    private int resultadoNumPruebaItemsSecuencia73 = 0;

    #endregion
    #region campos tanda3 ItemsSecuencia7

    private string itemNameItemsSecuencia73 = "RES_2";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia73;

    //tipo de test que es, en este caso las caras es type 2
    private int type3 = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia73;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia73 = 0;

    #endregion








    #region methods ItemsSecuencia7

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia7()
    {
        resultadoPruebaItemsSecuencia7 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia7 = 0;
        //enviamos respuesta
        SetItemsSecuencia7();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia7()
    {
        resultadoPruebaItemsSecuencia7 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia7 = 5;
        //enviamos respuesta
        SetItemsSecuencia7();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia7()
    {
        resultadoPruebaItemsSecuencia7 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia7 = 10;
        //enviamos respuesta
        SetItemsSecuencia7();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia7()
    {
        resultadoPruebaItemsSecuencia7 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia7 = 0;
        //enviamos respuesta
        SetItemsSecuencia7();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia7()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia7();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia7()
    {
        numSecsPartidaItemsSecuencia7= 0;
        return numSecsPartidaItemsSecuencia7;
    }

    #endregion
    #region Argumentos1

    public string itemNameItemSecuencia7()
    {
        return itemNameItemsSecuencia7;
    }

    public string[] softskillItemsSecuencia7()
    {
        softSkillItemsSecuencia7 = new string[1];
        softSkillItemsSecuencia7[0] = "Resiliencia";
        return softSkillItemsSecuencia7;
    }

    public int typeItemsSecuencia7()
    {

        return type;
    }

    public float[] puntuacionItemSecuencia7()
    {
        puntuacionItemsSecuencia7 = new float[1];
        puntuacionItemsSecuencia7[0] = resultadoNumPruebaItemsSecuencia7;
        return puntuacionItemsSecuencia7;
    }


    #endregion

    #region methods ItemsSecuencia72

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia72()
    {
        resultadoPruebaItemsSecuencia72 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia72 = 0;
        //enviamos respuesta
        SetItemsSecuencia72();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia72()
    {
        resultadoPruebaItemsSecuencia72 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia72 = 5;
        //enviamos respuesta
        SetItemsSecuencia72();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia72()
    {
        resultadoPruebaItemsSecuencia72 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia72 = 10;
        //enviamos respuesta
        SetItemsSecuencia72();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia72()
    {
        resultadoPruebaItemsSecuencia72 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia72 = 0;
        //enviamos respuesta
        SetItemsSecuencia72();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia72()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia72();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia72()
    {
        numSecsPartidaItemsSecuencia72 = 0;
        return numSecsPartidaItemsSecuencia72;
    }

    #endregion
    #region Argumentos2

    public string itemNameItemSecuencia72()
    {
        return itemNameItemsSecuencia72;
    }

    public string[] softskillItemsSecuencia72()
    {
        softSkillItemsSecuencia72 = new string[1];
        softSkillItemsSecuencia72[0] = "Trabajo en Equipo";
        return softSkillItemsSecuencia72;
    }

    public int typeItemsSecuencia72()
    {

        return type2;
    }

    public float[] puntuacionItemSecuencia72()
    {
        puntuacionItemsSecuencia72 = new float[1];
        puntuacionItemsSecuencia72[0] = resultadoNumPruebaItemsSecuencia72;
        return puntuacionItemsSecuencia72;
    }


    #endregion

    #region methods ItemsSecuencia73

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia73()
    {
        resultadoPruebaItemsSecuencia73 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia73 = 0;
        //enviamos respuesta
        SetItemsSecuencia73();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia73()
    {
        resultadoPruebaItemsSecuencia73 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia73 = 5;
        //enviamos respuesta
        SetItemsSecuencia73();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia73()
    {
        resultadoPruebaItemsSecuencia73 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia73 = 10;
        //enviamos respuesta
        SetItemsSecuencia73();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia73()
    {
        resultadoPruebaItemsSecuencia73 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia73 = 0;
        //enviamos respuesta
        SetItemsSecuencia73();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia73()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia73();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia73()
    {
        numSecsPartidaItemsSecuencia73 = 0;
        return numSecsPartidaItemsSecuencia73;
    }

    #endregion
    #region Argumentos3

    public string itemNameItemSecuencia73()
    {
        return itemNameItemsSecuencia73;
    }

    public string[] softskillItemsSecuencia73()
    {
        softSkillItemsSecuencia73 = new string[1];
        softSkillItemsSecuencia73[0] = "Resiliencia";
        return softSkillItemsSecuencia73;
    }

    public int typeItemsSecuencia73()
    {

        return type3;
    }

    public float[] puntuacionItemSecuencia73()
    {
        puntuacionItemsSecuencia73 = new float[1];
        puntuacionItemsSecuencia73[0] = resultadoNumPruebaItemsSecuencia73;
        return puntuacionItemsSecuencia73;
    }


    #endregion
}
