using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSecuencia6 : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    static private ManagerSecuencia6 _instanceItemsSecuencia6;
    static public ManagerSecuencia6 GetInstanceManagerItemsSecuencia6()
    {
        return _instanceItemsSecuencia6;
    }



    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceItemsSecuencia6 == null)
        {
            _instanceItemsSecuencia6= this;
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


    #region argumentos Tanda1ItemsSecuencia6

    private string resultadoPruebaItemsSecuencia6 = "";

    private int resultadoNumPruebaItemsSecuencia6 = 0;

    #endregion
    #region campos tanda1 ItemsSecuencia6

    private string itemNameItemsSecuencia6 = "CONF_2";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia6;

    //tipo de test que es, en este caso las caras es type 2
    private int type = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia6;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia6 = 0;

    #endregion

    #region argumentos Tanda2ItemsSecuencia6

    private string resultadoPruebaItemsSecuencia62 = "";

    private int resultadoNumPruebaItemsSecuencia62 = 0;

    #endregion
    #region campos tanda2 ItemsSecuencia6

    private string itemNameItemsSecuencia62 = "CONF_3";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia62;

    //tipo de test que es, en este caso las caras es type 2
    private int type2 = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia62;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia62 = 0;

    #endregion

    #region argumentos Tanda3ItemsSecuencia6

    private string resultadoPruebaItemsSecuencia63 = "";

    private int resultadoNumPruebaItemsSecuencia63 = 0;

    #endregion
    #region campos tanda3 ItemsSecuencia6

    private string itemNameItemsSecuencia63 = "CONF_4";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia63;

    //tipo de test que es, en este caso las caras es type 2
    private int type3 = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia63;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia63 = 0;

    #endregion

    #region argumentos Tanda4ItemsSecuencia6

    private string resultadoPruebaItemsSecuencia64 = "";

    private int resultadoNumPruebaItemsSecuencia64 = 0;

    #endregion
    #region campos tanda4 ItemsSecuencia6

    private string itemNameItemsSecuencia64 = "INT_4";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia64;

    //tipo de test que es, en este caso las caras es type 2
    private int type4 = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia64;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia64 = 0;

    #endregion






    #region methods ItemsSecuencia6

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia6()
    {
        resultadoPruebaItemsSecuencia6 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia6 = 10;
        //enviamos respuesta
        SetItemsSecuencia6();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia6()
    {
        resultadoPruebaItemsSecuencia6 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia6 = 5;
        //enviamos respuesta
        SetItemsSecuencia6();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia6()
    {
        resultadoPruebaItemsSecuencia6 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia6 = 0;
        //enviamos respuesta
        SetItemsSecuencia6();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia6()
    {
        resultadoPruebaItemsSecuencia6 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia6 = 0;
        //enviamos respuesta
        SetItemsSecuencia6();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia6()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia6();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia6()
    {
        numSecsPartidaItemsSecuencia6 = 0;
        return numSecsPartidaItemsSecuencia6;
    }

    #endregion
    #region Argumentos1

    public string itemNameItemSecuencia6()
    {
        return itemNameItemsSecuencia6;
    }

    public string[] softskillItemsSecuencia6()
    {
        softSkillItemsSecuencia6 = new string[1];
        softSkillItemsSecuencia6[0] = "Confianza";
        return softSkillItemsSecuencia6;
    }

    public int typeItemsSecuencia6()
    {

        return type;
    }

    public float[] puntuacionItemSecuencia6()
    {
        puntuacionItemsSecuencia6 = new float[1];
        puntuacionItemsSecuencia6[0] = resultadoNumPruebaItemsSecuencia6;
        return puntuacionItemsSecuencia6;
    }


    #endregion

    #region methods ItemsSecuencia62

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia62()
    {
        resultadoPruebaItemsSecuencia62 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia62 = 0;
        //enviamos respuesta
        SetItemsSecuencia62();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia62()
    {
        resultadoPruebaItemsSecuencia62 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia62 = 5;
        //enviamos respuesta
        SetItemsSecuencia62();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia62()
    {
        resultadoPruebaItemsSecuencia62 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia62 = 10;
        //enviamos respuesta
        SetItemsSecuencia62();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia62()
    {
        resultadoPruebaItemsSecuencia62 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia62 = 0;
        //enviamos respuesta
        SetItemsSecuencia62();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia62()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia62();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia62()
    {
        numSecsPartidaItemsSecuencia62 = 0;
        return numSecsPartidaItemsSecuencia62;
    }

    #endregion
    #region Argumentos2

    public string itemNameItemSecuencia62()
    {
        return itemNameItemsSecuencia62;
    }

    public string[] softskillItemsSecuencia62()
    {
        softSkillItemsSecuencia62 = new string[1];
        softSkillItemsSecuencia62[0] = "Confianza";
        return softSkillItemsSecuencia62;
    }

    public int typeItemsSecuencia62()
    {

        return type2;
    }

    public float[] puntuacionItemSecuencia62()
    {
        puntuacionItemsSecuencia62 = new float[1];
        puntuacionItemsSecuencia62[0] = resultadoNumPruebaItemsSecuencia62;
        return puntuacionItemsSecuencia62;
    }


    #endregion

    #region methods ItemsSecuencia63

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia63()
    {
        resultadoPruebaItemsSecuencia63 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia63 = 10;
        //enviamos respuesta
        SetItemsSecuencia63();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia63()
    {
        resultadoPruebaItemsSecuencia63 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia63 = 5;
        //enviamos respuesta
        SetItemsSecuencia63();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia63()
    {
        resultadoPruebaItemsSecuencia63 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia63 = 0;
        //enviamos respuesta
        SetItemsSecuencia63();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia63()
    {
        resultadoPruebaItemsSecuencia63 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia63 = 0;
        //enviamos respuesta
        SetItemsSecuencia63();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia63()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia63();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia63()
    {
        numSecsPartidaItemsSecuencia63 = 0;
        return numSecsPartidaItemsSecuencia63;
    }

    #endregion
    #region Argumentos3

    public string itemNameItemSecuencia63()
    {
        return itemNameItemsSecuencia63;
    }

    public string[] softskillItemsSecuencia63()
    {
        softSkillItemsSecuencia63 = new string[1];
        softSkillItemsSecuencia63[0] = "Confianza";
        return softSkillItemsSecuencia63;
    }

    public int typeItemsSecuencia63()
    {

        return type3;
    }

    public float[] puntuacionItemSecuencia63()
    {
        puntuacionItemsSecuencia63 = new float[1];
        puntuacionItemsSecuencia63[0] = resultadoNumPruebaItemsSecuencia63;
        return puntuacionItemsSecuencia63;
    }


    #endregion

    #region methods ItemsSecuencia64

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia64()
    {
        resultadoPruebaItemsSecuencia64 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia64 = 10;
        //enviamos respuesta
        SetItemsSecuencia64();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia64()
    {
        resultadoPruebaItemsSecuencia64 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia64 = 5;
        //enviamos respuesta
        SetItemsSecuencia64();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia64()
    {
        resultadoPruebaItemsSecuencia64= "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia64 = 0;
        //enviamos respuesta
        SetItemsSecuencia64();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia64()
    {
        resultadoPruebaItemsSecuencia64 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia64 = 0;
        //enviamos respuesta
        SetItemsSecuencia64();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia64()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia64();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia64()
    {
        numSecsPartidaItemsSecuencia64 = 0;
        return numSecsPartidaItemsSecuencia64;
    }

    #endregion
    #region Argumentos4

    public string itemNameItemSecuencia64()
    {
        return itemNameItemsSecuencia64;
    }

    public string[] softskillItemsSecuencia64()
    {
        softSkillItemsSecuencia64 = new string[1];
        softSkillItemsSecuencia64[0] = "Integridad";
        return softSkillItemsSecuencia64;
    }

    public int typeItemsSecuencia64()
    {

        return type4;
    }

    public float[] puntuacionItemSecuencia64()
    {
        puntuacionItemsSecuencia64 = new float[1];
        puntuacionItemsSecuencia64[0] = resultadoNumPruebaItemsSecuencia64;
        return puntuacionItemsSecuencia64;
    }


    #endregion
}
