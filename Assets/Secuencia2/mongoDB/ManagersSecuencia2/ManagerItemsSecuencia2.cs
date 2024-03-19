using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerItemsSecuencia2 : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    static private ManagerItemsSecuencia2 _instanceItemsSecuencia2;
    static public ManagerItemsSecuencia2 GetInstanceManagerItemsSecuencia2()
    {
        return _instanceItemsSecuencia2;
    }

   

    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceItemsSecuencia2 == null)
        {
            _instanceItemsSecuencia2 = this;
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


    #region argumentos Tanda1ItemsSecuencia2

    private string resultadoPruebaItemsSecuencia2 = "";

    private int resultadoNumPruebaItemsSecuencia2 = 0;

    #endregion
    #region campos tanda1 ItemsSecuencia2

    private string itemNameItemsSecuencia2 = "IN_1";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia2;

    //tipo de test que es, en este caso las caras es type 2
    private int type = 2;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia2;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia2 = 0;

    #endregion

    #region argumentos Tanda2ItemsSecuencia2

    private string resultadoPruebaItemsSecuencia22 = "";

    private int resultadoNumPruebaItemsSecuencia22 = 0;

    #endregion
    #region campos tanda2 ItemsSecuencia2

    private string itemNameItemsSecuencia22 = "IN_2";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia22;

    //tipo de test que es, en este caso las caras es type 2
    private int type2 = 2;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia22;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia22 = 0;

    #endregion





    #region methods ItemsSecuencia2

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia2()
    {
        resultadoPruebaItemsSecuencia2 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia2 = 0;
        //enviamos respuesta
        SetItemsSecuencia2();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia2()
    {
        resultadoPruebaItemsSecuencia2 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia2 = 5;
        //enviamos respuesta
        SetItemsSecuencia2();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia2()
    {
        resultadoPruebaItemsSecuencia2 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia2 = 10;
        //enviamos respuesta
        SetItemsSecuencia2();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia2()
    {
        resultadoPruebaItemsSecuencia2 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia2 = 0;
        //enviamos respuesta
        SetItemsSecuencia2();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia2()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia2();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia2()
    {
        numSecsPartidaItemsSecuencia2 = 0;
        return numSecsPartidaItemsSecuencia2;
    }

    #endregion
    #region ArgumentosCaras1

    public string itemNameItemSecuencia2()
    {
        return itemNameItemsSecuencia2;
    }

    public string[] softskillItemsSecuencia2()
    {
        softSkillItemsSecuencia2 = new string[1];
        softSkillItemsSecuencia2[0] = "Iniciativa";
        return softSkillItemsSecuencia2;
    }

    public int typeItemsSecuencia2()
    {

        return type;
    }

    public float[] puntuacionItemSecuencia2()
    {
        puntuacionItemsSecuencia2 = new float[1];
        puntuacionItemsSecuencia2[0] = resultadoNumPruebaItemsSecuencia2;
        return puntuacionItemsSecuencia2;
    }


    #endregion

    #region methods ItemsSecuencia22

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia22()
    {
        resultadoPruebaItemsSecuencia22 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia22 = 0;
        //enviamos respuesta
        SetItemsSecuencia22();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia22()
    {
        resultadoPruebaItemsSecuencia22 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia22 = 5;
        //enviamos respuesta
        SetItemsSecuencia22();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia22()
    {
        resultadoPruebaItemsSecuencia22 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia22 = 10;
        //enviamos respuesta
        SetItemsSecuencia22();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia22()
    {
        resultadoPruebaItemsSecuencia22 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia22 = 0;
        //enviamos respuesta
        SetItemsSecuencia22();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia22()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia22();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia22()
    {
        numSecsPartidaItemsSecuencia22 = 0;
        return numSecsPartidaItemsSecuencia22;
    }

    #endregion
    #region ArgumentosCaras2

    public string itemNameItemSecuencia22()
    {
        return itemNameItemsSecuencia22;
    }

    public string[] softskillItemsSecuencia22()
    {
        softSkillItemsSecuencia2 = new string[1];
        softSkillItemsSecuencia2[0] = "Iniciativa";
        return softSkillItemsSecuencia2;
    }

    public int typeItemsSecuencia22()
    {

        return type2;
    }

    public float[] puntuacionItemSecuencia22()
    {
        puntuacionItemsSecuencia22 = new float[1];
        puntuacionItemsSecuencia22[0] = resultadoNumPruebaItemsSecuencia22;
        return puntuacionItemsSecuencia22;
    }


    #endregion
}
