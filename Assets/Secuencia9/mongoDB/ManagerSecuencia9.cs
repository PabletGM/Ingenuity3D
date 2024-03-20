using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSecuencia9 : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    static private ManagerSecuencia9 _instanceItemsSecuencia9;
    static public ManagerSecuencia9 GetInstanceManagerItemsSecuencia9()
    {
        return _instanceItemsSecuencia9;
    }



    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceItemsSecuencia9== null)
        {
            _instanceItemsSecuencia9 = this;
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

    #region argumentos Tanda1ItemsSecuencia9

    private string resultadoPruebaItemsSecuencia9 = "";

    private int resultadoNumPruebaItemsSecuencia9 = 0;

    #endregion
    #region campos tanda1 ItemsSecuencia9

    private string itemNameItemsSecuencia9 = "CONF_5";

    //cantidad de softskills que mide y nombres
    private string[] softSkillItemsSecuencia9;

    //tipo de test que es, en este caso las caras es type 2
    private int type = 1;

    //cantidad de puntuaciones de todas las softskills que recoge
    private float[] puntuacionItemsSecuencia9;
    //numero de segundos por partida
    private int numSecsPartidaItemsSecuencia9 = 0;

    #endregion



    #region methods ItemsSecuencia9

    //metodo que elige la opcion A de la prueba1 de capacidad
    public void ChooseOptionAItemsSecuencia9()
    {
        resultadoPruebaItemsSecuencia9 = "a";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia9 = 10;
        //enviamos respuesta
        SetItemsSecuencia9();

    }

    //metodo que elige la opcion B de la prueba1 de capacidad
    public void ChooseOptionBItemsSecuencia9()
    {
        resultadoPruebaItemsSecuencia9 = "b";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia9 = 5;
        //enviamos respuesta
        SetItemsSecuencia9();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionCItemsSecuencia9()
    {
        resultadoPruebaItemsSecuencia9 = "c";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia9 = 0;
        //enviamos respuesta
        SetItemsSecuencia9();
    }

    //metodo que elige la opcion C de la prueba1 de capacidad
    public void ChooseOptionDSecuencia9()
    {
        resultadoPruebaItemsSecuencia9 = "d";
        //ponemos valor numerico segun el resultado
        resultadoNumPruebaItemsSecuencia9 = 0;
        //enviamos respuesta
        SetItemsSecuencia9();
    }

    //para pasar a siguiente test
    public void SetItemsSecuencia9()
    {
        //mandas solicitud para guardar en base de datos
        _instanceItems.RecolectarArgumentosItemsSecuencia9();
        //como ya has mandando solicitud de test anterior a backend reinicias valores
        //para reutilizar parametros vacios
    }

    public int TiempoPartidaItemsSecuencia9()
    {
        numSecsPartidaItemsSecuencia9 = 0;
        return numSecsPartidaItemsSecuencia9;
    }

    #endregion
    #region Argumentos1

    public string itemNameItemSecuencia9()
    {
        return itemNameItemsSecuencia9;
    }

    public string[] softskillItemsSecuencia9()
    {
        softSkillItemsSecuencia9 = new string[1];
        softSkillItemsSecuencia9[0] = "Confianza";
        return softSkillItemsSecuencia9;
    }

    public int typeItemsSecuencia9()
    {

        return type;
    }

    public float[] puntuacionItemSecuencia9()
    {
        puntuacionItemsSecuencia9 = new float[1];
        puntuacionItemsSecuencia9[0] = resultadoNumPruebaItemsSecuencia9;
        return puntuacionItemsSecuencia9;
    }


    #endregion

}
