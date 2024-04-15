using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerItemsSecuencia5 : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    static private ManagerItemsSecuencia5 _instanceItemsSecuencia5;
    static public ManagerItemsSecuencia5 GetInstanceManagerItemsSecuencia5()
    {
        return _instanceItemsSecuencia5;
    }



    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceItemsSecuencia5 == null)
        {
            _instanceItemsSecuencia5 = this;
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


    #region argumentos Tanda1ItemsSecuencia5

    private string resultadoPruebaItemsSecuencia5 = "";

    private int resultadoNumPruebaItemsSecuencia5 = 0;

    #endregion
    #region campos tanda1 ItemsSecuencia5

    private string itemNameItemsSecuencia5 = "INT_3";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia5;

    //tipo de test que es, en este caso las caras es type 2
    private int type = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia5;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia5 = 0;

    #endregion

    //#region argumentos Tanda2ItemsSecuencia5

    //private string resultadoPruebaItemsSecuencia52 = "";

    //private int resultadoNumPruebaItemsSecuencia52 = 0;

    //#endregion
    //#region campos tanda2 ItemsSecuencia5

    //private string itemNameItemsSecuencia52 = "RES_3";

    ////cantidad de softskills que mide y nombres
    //private string[] softSkillItemsSecuencia52;

    ////tipo de test que es, en este caso las caras es type 2
    //private int type2 = 1;

    ////cantidad de puntuaciones de todas las softskills que recoge
    //private float[] puntuacionItemsSecuencia52;
    ////numero de segundos por partida
    //private int numSecsPartidaItemsSecuencia52 = 0;

    //#endregion

    #region argumentos Tanda3ItemsSecuencia5

    private string resultadoPruebaItemsSecuencia53 = "";

    private int resultadoNumPruebaItemsSecuencia53 = 0;

    #endregion
    #region campos tanda3 ItemsSecuencia5

    private string itemNameItemsSecuencia53 = "INT_1";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia53;

    //tipo de test que es, en este caso las caras es type 2
    private int type3 = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia53;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia53 = 0;

    #endregion




    #region methods ItemsSecuencia5

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia5()
    {
        resultadoPruebaItemsSecuencia5 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia5 = 10;
        //enviamos respuesta
        SetItemsSecuencia5();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia5()
    {
        resultadoPruebaItemsSecuencia5 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia5 = 5;
        //enviamos respuesta
        SetItemsSecuencia5();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia5()
    {
        resultadoPruebaItemsSecuencia5 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia5 =0;
        //enviamos respuesta
        SetItemsSecuencia5();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia5()
    {
        resultadoPruebaItemsSecuencia5 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia5 = 0;
        //enviamos respuesta
        SetItemsSecuencia5();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia5()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia5();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia5()
    {
        numSecsPartidaItemsSecuencia5 = 0;
        return numSecsPartidaItemsSecuencia5;
    }

    #endregion
    #region Argumentos1

    public string itemNameItemSecuencia5()
    {
        return itemNameItemsSecuencia5;
    }

    public string[] softskillItemsSecuencia5()
    {
        softSkillItemsSecuencia5 = new string[1];
        softSkillItemsSecuencia5[0] = "integridad";
        return softSkillItemsSecuencia5;
    }

    public int typeItemsSecuencia5()
    {

        return type;
    }

    public float[] puntuacionItemSecuencia5()
    {
        puntuacionItemsSecuencia5 = new float[1];
        puntuacionItemsSecuencia5[0] = resultadoNumPruebaItemsSecuencia5;
        return puntuacionItemsSecuencia5;
    }


    #endregion

    //#region methods ItemsSecuencia52

    ////metodo que elige la opcion A de la prueba1 de capacidad
    //public void ChooseOptionAItemsSecuencia52()
    //{
    //    resultadoPruebaItemsSecuencia52 = "a";
    //    //ponemos valor numerico segun el resultado
    //    resultadoNumPruebaItemsSecuencia52 = 0;
    //    //enviamos respuesta
    //    SetItemsSecuencia52();

    //}

    ////metodo que elige la opcion B de la prueba1 de capacidad
    //public void ChooseOptionBItemsSecuencia52()
    //{
    //    resultadoPruebaItemsSecuencia52 = "b";
    //    //ponemos valor numerico segun el resultado
    //    resultadoNumPruebaItemsSecuencia52 = 5;
    //    //enviamos respuesta
    //    SetItemsSecuencia52();
    //}

    ////metodo que elige la opcion C de la prueba1 de capacidad
    //public void ChooseOptionCItemsSecuencia52()
    //{
    //    resultadoPruebaItemsSecuencia52 = "c";
    //    //ponemos valor numerico segun el resultado
    //    resultadoNumPruebaItemsSecuencia52 = 10;
    //    //enviamos respuesta
    //    SetItemsSecuencia52();
    //}

    ////metodo que elige la opcion C de la prueba1 de capacidad
    //public void ChooseOptionDSecuencia52()
    //{
    //    resultadoPruebaItemsSecuencia52 = "d";
    //    //ponemos valor numerico segun el resultado
    //    resultadoNumPruebaItemsSecuencia52 = 0;
    //    //enviamos respuesta
    //    SetItemsSecuencia52();
    //}

    ////para pasar a siguiente test
    //public void SetItemsSecuencia52()
    //{
    //    //mandas solicitud para guardar en base de datos
    //    _instanceItems.RecolectarArgumentosItemsSecuencia52();
    //    //como ya has mandando solicitud de test anterior a backend reinicias valores
    //    //para reutilizar parametros vacios
    //}

    //public int TiempoPartidaItemsSecuencia52()
    //{
    //    numSecsPartidaItemsSecuencia52 = 0;
    //    return numSecsPartidaItemsSecuencia52;
    //}

    //#endregion
    //#region Argumentos2

    //public string itemNameItemSecuencia52()
    //{
    //    return itemNameItemsSecuencia52;
    //}

    //public string[] softskillItemsSecuencia52()
    //{
    //    softSkillItemsSecuencia52 = new string[1];
    //    softSkillItemsSecuencia52[0] = "resiliencia";
    //    return softSkillItemsSecuencia52;
    //}

    //public int typeItemsSecuencia52()
    //{

    //    return type2;
    //}

    //public float[] puntuacionItemSecuencia52()
    //{
    //    puntuacionItemsSecuencia52 = new float[1];
    //    puntuacionItemsSecuencia52[0] = resultadoNumPruebaItemsSecuencia52;
    //    return puntuacionItemsSecuencia52;
    //}


    //#endregion

    #region methods ItemsSecuencia53

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia53()
    {
        resultadoPruebaItemsSecuencia53 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia53 = 10;
        //enviamos respuesta
        SetItemsSecuencia53();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia53()
    {
        resultadoPruebaItemsSecuencia53 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia53 = 5;
        //enviamos respuesta
        SetItemsSecuencia53();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia53()
    {
        resultadoPruebaItemsSecuencia53 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia53 =0;
        //enviamos respuesta
        SetItemsSecuencia53();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia53()
    {
        resultadoPruebaItemsSecuencia53 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia53 = 0;
        //enviamos respuesta
        SetItemsSecuencia53();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia53()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia53();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia53()
    {
        numSecsPartidaItemsSecuencia53 = 0;
        return numSecsPartidaItemsSecuencia53;
    }

    #endregion
    #region Argumentos3

    public string itemNameItemSecuencia53()
    {
        return itemNameItemsSecuencia53;
    }

    public string[] softskillItemsSecuencia53()
    {
        softSkillItemsSecuencia53 = new string[1];
        softSkillItemsSecuencia53[0] = "integridad";
        return softSkillItemsSecuencia53;
    }

    public int typeItemsSecuencia53()
    {

        return type3;
    }

    public float[] puntuacionItemSecuencia53()
    {
        puntuacionItemsSecuencia53 = new float[1];
        puntuacionItemsSecuencia53[0] = resultadoNumPruebaItemsSecuencia53;
        return puntuacionItemsSecuencia53;
    }


    #endregion
}
