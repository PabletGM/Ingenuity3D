using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerItemsSecuencia3 : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    static private ManagerItemsSecuencia3 _instanceItemsSecuencia3;
    static public ManagerItemsSecuencia3 GetInstanceManagerItemsSecuencia3()
    {
        return _instanceItemsSecuencia3;
    }

    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceItemsSecuencia3 == null)
        {
            _instanceItemsSecuencia3 = this;
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

    #region argumentos Tanda1ItemsSecuencia3

    private string resultadoPruebaItemsSecuencia3 = "";

    private int resultadoNumPruebaItemsSecuencia3 = 0;

    #endregion
    #region campos tanda1 ItemsSecuencia3

    private string itemNameItemsSecuencia3 = "INT_2";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia3;

    //tipo de test que es, en este caso las caras es type 2
    private int type = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia3;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia3 = 0;

    #endregion


    #region methods ItemsSecuencia3

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia3()
    {
        resultadoPruebaItemsSecuencia3 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia3 = 0;
        //enviamos respuesta
        SetItemsSecuencia3();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia3()
    {
        resultadoPruebaItemsSecuencia3 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia3 = 5;
        //enviamos respuesta
        SetItemsSecuencia3();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia3()
    {
        resultadoPruebaItemsSecuencia3 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia3 = 10;
        //enviamos respuesta
        SetItemsSecuencia3();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia3()
    {
        resultadoPruebaItemsSecuencia3 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia3 = 0;
        //enviamos respuesta
        SetItemsSecuencia3();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia3()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia3();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia3()
    {
        numSecsPartidaItemsSecuencia3 = 0;
        return numSecsPartidaItemsSecuencia3;
    }

    #endregion
    #region ArgumentosCaras1

    public string itemNameItemSecuencia3()
    {
        return itemNameItemsSecuencia3;
    }

    public string[] softskillItemsSecuencia3()
    {
        softSkillItemsSecuencia3 = new string[1];
        softSkillItemsSecuencia3[0] = "integridad";
        return softSkillItemsSecuencia3;
    }

    public int typeItemsSecuencia3()
    {

        return type;
    }

    public float[] puntuacionItemSecuencia3()
    {
        puntuacionItemsSecuencia3 = new float[1];
        puntuacionItemsSecuencia3[0] = resultadoNumPruebaItemsSecuencia3;
        return puntuacionItemsSecuencia3;
    }


    #endregion
}
