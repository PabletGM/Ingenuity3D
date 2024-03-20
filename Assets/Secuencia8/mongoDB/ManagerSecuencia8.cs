using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSecuencia8 : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    static private ManagerSecuencia8 _instanceItemsSecuencia8;
    static public ManagerSecuencia8 GetInstanceManagerItemsSecuencia8()
    {
        return _instanceItemsSecuencia8;
    }



    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceItemsSecuencia8 == null)
        {
            _instanceItemsSecuencia8 = this;
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

    #region argumentos Tanda1ItemsSecuencia8

    private string resultadoPruebaItemsSecuencia8 = "";

    private int resultadoNumPruebaItemsSecuencia8 = 0;

    #endregion
    #region campos tanda1 ItemsSecuencia8

    private string itemNameItemsSecuencia8 = "EQUI_4";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia8;

    //tipo de test que es, en este caso las caras es type 2
    private int type = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia8;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia8 = 0;

    #endregion

    #region argumentos Tanda2ItemsSecuencia8

    private string resultadoPruebaItemsSecuencia82 = "";

    private int resultadoNumPruebaItemsSecuencia82 = 0;

    #endregion
    #region campos tanda2 ItemsSecuencia8

    private string itemNameItemsSecuencia82 = "EQUI_3";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia82;

    //tipo de test que es, en este caso las caras es type 2
    private int type2 = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia82;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia82 = 0;

    #endregion




    #region methods ItemsSecuencia8

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia8()
    {
        resultadoPruebaItemsSecuencia8 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia8 = 0;
        //enviamos respuesta
        SetItemsSecuencia8();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia8()
    {
        resultadoPruebaItemsSecuencia8 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia8 = 5;
        //enviamos respuesta
        SetItemsSecuencia8();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia8()
    {
        resultadoPruebaItemsSecuencia8 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia8 = 10;
        //enviamos respuesta
        SetItemsSecuencia8();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia8()
    {
        resultadoPruebaItemsSecuencia8 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia8 = 0;
        //enviamos respuesta
        SetItemsSecuencia8();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia8()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia8();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia8()
    {
        numSecsPartidaItemsSecuencia8 = 0;
        return numSecsPartidaItemsSecuencia8;
    }

    #endregion
    #region Argumentos1

    public string itemNameItemSecuencia8()
    {
        return itemNameItemsSecuencia8;
    }

    public string[] softskillItemsSecuencia7()
    {
        softSkillItemsSecuencia8 = new string[1];
        softSkillItemsSecuencia8[0] = "Trabajo en Equipo";
        return softSkillItemsSecuencia8;
    }

    public int typeItemsSecuencia8()
    {

        return type;
    }

    public float[] puntuacionItemSecuencia8()
    {
        puntuacionItemsSecuencia8 = new float[1];
        puntuacionItemsSecuencia8[0] = resultadoNumPruebaItemsSecuencia8;
        return puntuacionItemsSecuencia8;
    }


    #endregion

    #region methods ItemsSecuencia82

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia82()
    {
        resultadoPruebaItemsSecuencia82 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia82 = 0;
        //enviamos respuesta
        SetItemsSecuencia82();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia82()
    {
        resultadoPruebaItemsSecuencia82 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia82 = 5;
        //enviamos respuesta
        SetItemsSecuencia82();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia82()
    {
        resultadoPruebaItemsSecuencia82 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia82 = 10;
        //enviamos respuesta
        SetItemsSecuencia82();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia82()
    {
        resultadoPruebaItemsSecuencia82 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia82 = 0;
        //enviamos respuesta
        SetItemsSecuencia82();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia82()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia82();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia82()
    {
        numSecsPartidaItemsSecuencia82 = 0;
        return numSecsPartidaItemsSecuencia82;
    }

    #endregion
    #region Argumentos2

    public string itemNameItemSecuencia82()
    {
        return itemNameItemsSecuencia82;
    }

    public string[] softskillItemsSecuencia82()
    {
        softSkillItemsSecuencia82 = new string[1];
        softSkillItemsSecuencia82[0] = "Trabajo en Equipo";
        return softSkillItemsSecuencia82;
    }

    public int typeItemsSecuencia82()
    {

        return type2;
    }

    public float[] puntuacionItemSecuencia82()
    {
        puntuacionItemsSecuencia82 = new float[1];
        puntuacionItemsSecuencia82[0] = resultadoNumPruebaItemsSecuencia82;
        return puntuacionItemsSecuencia82;
    }


    #endregion
}
