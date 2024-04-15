using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Networking;

public class InfoItemsSecuenciasMongoDB : MonoBehaviour
{
    //instance
    static private InfoItemsSecuenciasMongoDB _instanceItems;

    //conexion con Managers, SECUENCIA 2
    ManagerTareaCaras _myManagerCaras;
    ManagerItemsSecuencia2 _myManagerItemsSecuencia2;

    //conexion con Managers, SECUENCIA 3
    ManagerItemsSecuencia3 _myManagerItemsSecuencia3;

    //conexion con Managers, SECUENCIA 4
    ManagerItemsSecuencia4 _myManagerItemsSecuencia4;

    //conexion con Managers, SECUENCIA 5
    ManagerItemsSecuencia5 _myManagerItemsSecuencia5;

    //conexion con Managers, SECUENCIA 6
    ManagerSecuencia6 _myManagerItemsSecuencia6;

    //conexion con Managers, SECUENCIA 7
    ManagerSecuencia7 _myManagerItemsSecuencia7;

    //conexion con Managers, SECUENCIA 8
    ManagerSecuencia8 _myManagerItemsSecuencia8;

    //conexion con Managers, SECUENCIA 9
    ManagerSecuencia9 _myManagerItemsSecuencia9;


    //recoger token con loginRegister
    UIManagerLogin _myUIManagerLogin;

    //base URL
    string baseUrl = "https://backendingenuity.onrender.com/";


    //Access token
    private string access_token = "";

    private void Awake()
    {
        //si la instancia no existe se hace este script la instancia
        if (_instanceItems == null)
        {
            _instanceItems = this;
            
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
        _myManagerCaras = ManagerTareaCaras.GetInstanceManagerTareaCaras();
        //conectamos con info items secuencia 2
        _myManagerItemsSecuencia2 = ManagerItemsSecuencia2.GetInstanceManagerItemsSecuencia2();
        //conectamos con info items secuencia 3
        _myManagerItemsSecuencia3 = ManagerItemsSecuencia3.GetInstanceManagerItemsSecuencia3();
        //conectamos con info items secuencia 4
        _myManagerItemsSecuencia4 = ManagerItemsSecuencia4.GetInstanceManagerItemsSecuencia4();
        //conectamos con info items secuencia 5
        _myManagerItemsSecuencia5 = ManagerItemsSecuencia5.GetInstanceManagerItemsSecuencia5();
        //conectamos con info items secuencia 6
        _myManagerItemsSecuencia6 = ManagerSecuencia6.GetInstanceManagerItemsSecuencia6();
        //conectamos con info items secuencia 7
        _myManagerItemsSecuencia7 = ManagerSecuencia7.GetInstanceManagerItemsSecuencia7();
        //conectamos con info items secuencia 8
        _myManagerItemsSecuencia8 = ManagerSecuencia8.GetInstanceManagerItemsSecuencia8();
        //conectamos con info items secuencia 9
        _myManagerItemsSecuencia9 = ManagerSecuencia9.GetInstanceManagerItemsSecuencia9();

        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();
    }

    static public InfoItemsSecuenciasMongoDB GetIstanceInfoItemsSecuenciasMongoDB()
    {
        return _instanceItems;
    }



    #region methodsConnectCarasMongoDB
    [System.Obsolete]
    public void RecolectarArgumentosCARAS_1()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerCaras.TiempoPartidaCaras1();
        string itemNameCaras1 = _myManagerCaras.itemNameCARAS_1();
        string[] softskillCaras1 = _myManagerCaras.softskillCARAS_1();
        int type = _myManagerCaras.typeCARAS_1();
        float[] puntuacionCaras1 = _myManagerCaras.puntuacionCARAS_1();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras1, softskillCaras1, type, puntuacionCaras1, totalTime));
    }

    [System.Obsolete]
    public void RecolectarArgumentosCARAS_2()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime2 = _myManagerCaras.TiempoPartidaCaras2();
        string itemNameCaras2 = _myManagerCaras.itemNameCARAS_2();
        string[] softskillCaras2 = _myManagerCaras.softskillCARAS_2();
        int type2 = _myManagerCaras.typeCARAS_2();
        float[] puntuacionCaras2 = _myManagerCaras.puntuacionCARAS_2();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras2, softskillCaras2, type2, puntuacionCaras2, totalTime2));
    }

    [System.Obsolete]
    public void RecolectarArgumentosCARAS_3()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime3 = _myManagerCaras.TiempoPartidaCaras3();
        string itemNameCaras3 = _myManagerCaras.itemNameCARAS_3();
        string[] softskillCaras3 = _myManagerCaras.softskillCARAS_3();
        int type3 = _myManagerCaras.typeCARAS_3();
        float[] puntuacionCaras3 = _myManagerCaras.puntuacionCARAS_3();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras3, softskillCaras3, type3, puntuacionCaras3, totalTime3));
    }

    [System.Obsolete]
    public void RecolectarArgumentosCARAS_4()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime4 = _myManagerCaras.TiempoPartidaCaras4();
        string itemNameCaras4 = _myManagerCaras.itemNameCARAS_4();
        string[] softskillCaras4 = _myManagerCaras.softskillCARAS_4();
        int type4 = _myManagerCaras.typeCARAS_4();
        float[] puntuacionCaras4 = _myManagerCaras.puntuacionCARAS_4();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras4, softskillCaras4, type4, puntuacionCaras4, totalTime4));
    }

    [System.Obsolete]
    public void RecolectarArgumentosCARAS_5()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime5 = _myManagerCaras.TiempoPartidaCaras5();
        string itemNameCaras5 = _myManagerCaras.itemNameCARAS_5();
        string[] softskillCaras5 = _myManagerCaras.softskillCARAS_5();
        int type5= _myManagerCaras.typeCARAS_5();
        float[] puntuacionCaras5 = _myManagerCaras.puntuacionCARAS_5();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras5, softskillCaras5, type5, puntuacionCaras5, totalTime5));
    }

    [System.Obsolete]
    public void RecolectarArgumentosCARAS_6()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime6 = _myManagerCaras.TiempoPartidaCaras6();
        string itemNameCaras6 = _myManagerCaras.itemNameCARAS_6();
        string[] softskillCaras6 = _myManagerCaras.softskillCARAS_6();
        int type6 = _myManagerCaras.typeCARAS_6();
        float[] puntuacionCaras6 = _myManagerCaras.puntuacionCARAS_6();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras6, softskillCaras6, type6, puntuacionCaras6, totalTime6));
    }

    [System.Obsolete]
    public void RecolectarArgumentosCARAS_7()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime7 = _myManagerCaras.TiempoPartidaCaras7();
        string itemNameCaras7 = _myManagerCaras.itemNameCARAS_7();
        string[] softskillCaras7 = _myManagerCaras.softskillCARAS_7();
        int type7 = _myManagerCaras.typeCARAS_7();
        float[] puntuacionCaras7 = _myManagerCaras.puntuacionCARAS_7();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras7, softskillCaras7, type7, puntuacionCaras7, totalTime7));
    }

    [System.Obsolete]
    public void RecolectarArgumentosCARAS_8()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime8 = _myManagerCaras.TiempoPartidaCaras8();
        string itemNameCaras8 = _myManagerCaras.itemNameCARAS_8();
        string[] softskillCaras8 = _myManagerCaras.softskillCARAS_8();
        int type8 = _myManagerCaras.typeCARAS_8();
        float[] puntuacionCaras8 = _myManagerCaras.puntuacionCARAS_8();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras8, softskillCaras8, type8, puntuacionCaras8, totalTime8));
    }

    [System.Obsolete]
    public void RecolectarArgumentosCARAS_9()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime9 = _myManagerCaras.TiempoPartidaCaras9();
        string itemNameCaras9 = _myManagerCaras.itemNameCARAS_9();
        string[] softskillCaras9 = _myManagerCaras.softskillCARAS_9();
        int type9 = _myManagerCaras.typeCARAS_9();
        float[] puntuacionCaras9 = _myManagerCaras.puntuacionCARAS_9();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras9, softskillCaras9, type9, puntuacionCaras9, totalTime9));
    }

    [System.Obsolete]
    public void RecolectarArgumentosCARAS_10()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime10 = _myManagerCaras.TiempoPartidaCaras10();
        string itemNameCaras10 = _myManagerCaras.itemNameCARAS_10();
        string[] softskillCaras10 = _myManagerCaras.softskillCARAS_10();
        int type10 = _myManagerCaras.typeCARAS_10();
        float[] puntuacionCaras2 = _myManagerCaras.puntuacionCARAS_10();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameCaras10, softskillCaras10, type10, puntuacionCaras2, totalTime10));
    }
    #endregion

    #region MethodsConnectItemsSecuencia2
    public void RecolectarArgumentosItemsSecuencia2()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia2.TiempoPartidaItemsSecuencia2();
        string itemNameItemsSecuencia2 = _myManagerItemsSecuencia2.itemNameItemSecuencia2();
        string[] softskillItemsSecuencia2 = _myManagerItemsSecuencia2.softskillItemsSecuencia2();
        int type = _myManagerItemsSecuencia2.typeItemsSecuencia2();
        float[] puntuacionItemsSecuencia2 = _myManagerItemsSecuencia2.puntuacionItemSecuencia2();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia2, softskillItemsSecuencia2, type, puntuacionItemsSecuencia2, totalTime));
    }
    public void RecolectarArgumentosItemsSecuencia22()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia2.TiempoPartidaItemsSecuencia22();
        string itemNameItemsSecuencia2 = _myManagerItemsSecuencia2.itemNameItemSecuencia22();
        string[] softskillItemsSecuencia2 = _myManagerItemsSecuencia2.softskillItemsSecuencia22();
        int type = _myManagerItemsSecuencia2.typeItemsSecuencia22();
        float[] puntuacionItemsSecuencia2 = _myManagerItemsSecuencia2.puntuacionItemSecuencia22();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia2, softskillItemsSecuencia2, type, puntuacionItemsSecuencia2, totalTime));
    }
    #endregion

    #region MethodsConnectItemsSecuencia3
    public void RecolectarArgumentosItemsSecuencia3()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia3.TiempoPartidaItemsSecuencia3();
        string itemNameItemsSecuencia3 = _myManagerItemsSecuencia3.itemNameItemSecuencia3();
        string[] softskillItemsSecuencia3 = _myManagerItemsSecuencia3.softskillItemsSecuencia3();
        int type = _myManagerItemsSecuencia3.typeItemsSecuencia3();
        float[] puntuacionItemsSecuencia3 = _myManagerItemsSecuencia3.puntuacionItemSecuencia3();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia3, softskillItemsSecuencia3, type, puntuacionItemsSecuencia3, totalTime));
    }

    public void RecolectarArgumentosItemsSecuencia32()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia3.TiempoPartidaItemsSecuencia32();
        string itemNameItemsSecuencia3 = _myManagerItemsSecuencia3.itemNameItemSecuencia32();
        string[] softskillItemsSecuencia3 = _myManagerItemsSecuencia3.softskillItemsSecuencia32();
        int type = _myManagerItemsSecuencia3.typeItemsSecuencia32();
        float[] puntuacionItemsSecuencia3 = _myManagerItemsSecuencia3.puntuacionItemSecuencia32();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia3, softskillItemsSecuencia3, type, puntuacionItemsSecuencia3, totalTime));
    }

    #endregion

    #region MethodsConnectItemsSecuencia4
    public void RecolectarArgumentosItemsSecuencia4()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia4.TiempoPartidaItemsSecuencia4();
        string itemNameItemsSecuencia4 = _myManagerItemsSecuencia4.itemNameItemSecuencia4();
        string[] softskillItemsSecuencia4 = _myManagerItemsSecuencia4.softskillItemsSecuencia4();
        int type = _myManagerItemsSecuencia4.typeItemsSecuencia4();
        float[] puntuacionItemsSecuencia4 = _myManagerItemsSecuencia4.puntuacionItemSecuencia4();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia4, softskillItemsSecuencia4, type, puntuacionItemsSecuencia4, totalTime));
    }

    public void RecolectarArgumentosItemsSecuencia42()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia4.TiempoPartidaItemsSecuencia42();
        string itemNameItemsSecuencia4 = _myManagerItemsSecuencia4.itemNameItemSecuencia42();
        string[] softskillItemsSecuencia4 = _myManagerItemsSecuencia4.softskillItemsSecuencia42();
        int type = _myManagerItemsSecuencia4.typeItemsSecuencia42();
        float[] puntuacionItemsSecuencia4 = _myManagerItemsSecuencia4.puntuacionItemSecuencia42();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia4, softskillItemsSecuencia4, type, puntuacionItemsSecuencia4, totalTime));
    }

    public void RecolectarArgumentosItemsSecuencia43()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia4.TiempoPartidaItemsSecuencia43();
        string itemNameItemsSecuencia4 = _myManagerItemsSecuencia4.itemNameItemSecuencia43();
        string[] softskillItemsSecuencia4 = _myManagerItemsSecuencia4.softskillItemsSecuencia43();
        int type = _myManagerItemsSecuencia4.typeItemsSecuencia43();
        float[] puntuacionItemsSecuencia4 = _myManagerItemsSecuencia4.puntuacionItemSecuencia43();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia4, softskillItemsSecuencia4, type, puntuacionItemsSecuencia4, totalTime));
    }

    #endregion

    #region MethodsConnectItemsSecuencia5
    public void RecolectarArgumentosItemsSecuencia5()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia5.TiempoPartidaItemsSecuencia5();
        string itemNameItemsSecuencia5 = _myManagerItemsSecuencia5.itemNameItemSecuencia5();
        string[] softskillItemsSecuencia5 = _myManagerItemsSecuencia5.softskillItemsSecuencia5();
        int type = _myManagerItemsSecuencia5.typeItemsSecuencia5();
        float[] puntuacionItemsSecuencia5 = _myManagerItemsSecuencia5.puntuacionItemSecuencia5();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia5, softskillItemsSecuencia5, type, puntuacionItemsSecuencia5, totalTime));
    }

    //public void RecolectarArgumentosItemsSecuencia52()
    //{
    //    //para recolectar el token
    //    _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

    //    int totalTime = _myManagerItemsSecuencia5.TiempoPartidaItemsSecuencia52();
    //    string itemNameItemsSecuencia5 = _myManagerItemsSecuencia5.itemNameItemSecuencia52();
    //    string[] softskillItemsSecuencia5 = _myManagerItemsSecuencia5.softskillItemsSecuencia52();
    //    int type = _myManagerItemsSecuencia5.typeItemsSecuencia52();
    //    float[] puntuacionItemsSecuencia5 = _myManagerItemsSecuencia5.puntuacionItemSecuencia52();

    //    //recolectar token de script login register
    //    access_token = _myUIManagerLogin.GetAccessToken();
    //    //access token temporal
    //    //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
    //    //se empieza corrutina hoyosMongoDB
    //    StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia5, softskillItemsSecuencia5, type, puntuacionItemsSecuencia5, totalTime));
    //}

    public void RecolectarArgumentosItemsSecuencia53()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia5.TiempoPartidaItemsSecuencia53();
        string itemNameItemsSecuencia5 = _myManagerItemsSecuencia5.itemNameItemSecuencia53();
        string[] softskillItemsSecuencia5 = _myManagerItemsSecuencia5.softskillItemsSecuencia53();
        int type = _myManagerItemsSecuencia5.typeItemsSecuencia53();
        float[] puntuacionItemsSecuencia5 = _myManagerItemsSecuencia5.puntuacionItemSecuencia53();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia5, softskillItemsSecuencia5, type, puntuacionItemsSecuencia5, totalTime));
    }

    #endregion

    #region MethodsConnectItemsSecuencia6
    public void RecolectarArgumentosItemsSecuencia6()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia6.TiempoPartidaItemsSecuencia6();
        string itemNameItemsSecuencia5 = _myManagerItemsSecuencia6.itemNameItemSecuencia6();
        string[] softskillItemsSecuencia5 = _myManagerItemsSecuencia6.softskillItemsSecuencia6();
        int type = _myManagerItemsSecuencia6.typeItemsSecuencia6();
        float[] puntuacionItemsSecuencia5 = _myManagerItemsSecuencia6.puntuacionItemSecuencia6();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia5, softskillItemsSecuencia5, type, puntuacionItemsSecuencia5, totalTime));
    }

    public void RecolectarArgumentosItemsSecuencia62()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia6.TiempoPartidaItemsSecuencia62();
        string itemNameItemsSecuencia5 = _myManagerItemsSecuencia6.itemNameItemSecuencia62();
        string[] softskillItemsSecuencia5 = _myManagerItemsSecuencia6.softskillItemsSecuencia62();
        int type = _myManagerItemsSecuencia6.typeItemsSecuencia62();
        float[] puntuacionItemsSecuencia5 = _myManagerItemsSecuencia6.puntuacionItemSecuencia62();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia5, softskillItemsSecuencia5, type, puntuacionItemsSecuencia5, totalTime));
    }

    public void RecolectarArgumentosItemsSecuencia63()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia6.TiempoPartidaItemsSecuencia63();
        string itemNameItemsSecuencia6 = _myManagerItemsSecuencia6.itemNameItemSecuencia63();
        string[] softskillItemsSecuencia6 = _myManagerItemsSecuencia6.softskillItemsSecuencia63();
        int type = _myManagerItemsSecuencia6.typeItemsSecuencia63();
        float[] puntuacionItemsSecuencia6 = _myManagerItemsSecuencia6.puntuacionItemSecuencia63();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia6, softskillItemsSecuencia6, type, puntuacionItemsSecuencia6, totalTime));
    }

    public void RecolectarArgumentosItemsSecuencia64()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia6.TiempoPartidaItemsSecuencia64();
        string itemNameItemsSecuencia6 = _myManagerItemsSecuencia6.itemNameItemSecuencia64();
        string[] softskillItemsSecuencia6 = _myManagerItemsSecuencia6.softskillItemsSecuencia64();
        int type = _myManagerItemsSecuencia6.typeItemsSecuencia64();
        float[] puntuacionItemsSecuencia6 = _myManagerItemsSecuencia6.puntuacionItemSecuencia64();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia6, softskillItemsSecuencia6, type, puntuacionItemsSecuencia6, totalTime));
    }

    #endregion

    #region MethodsConnectItemsSecuencia7
    public void RecolectarArgumentosItemsSecuencia7()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia7.TiempoPartidaItemsSecuencia7();
        string itemNameItemsSecuencia7 = _myManagerItemsSecuencia7.itemNameItemSecuencia7();
        string[] softskillItemsSecuencia7 = _myManagerItemsSecuencia7.softskillItemsSecuencia7();
        int type = _myManagerItemsSecuencia7.typeItemsSecuencia7();
        float[] puntuacionItemsSecuencia5 = _myManagerItemsSecuencia7.puntuacionItemSecuencia7();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia7, softskillItemsSecuencia7, type, puntuacionItemsSecuencia5, totalTime));
    }

    public void RecolectarArgumentosItemsSecuencia72()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia7.TiempoPartidaItemsSecuencia72();
        string itemNameItemsSecuencia7 = _myManagerItemsSecuencia7.itemNameItemSecuencia72();
        string[] softskillItemsSecuencia7 = _myManagerItemsSecuencia7.softskillItemsSecuencia72();
        int type = _myManagerItemsSecuencia7.typeItemsSecuencia72();
        float[] puntuacionItemsSecuencia7 = _myManagerItemsSecuencia7.puntuacionItemSecuencia72();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia7, softskillItemsSecuencia7, type, puntuacionItemsSecuencia7, totalTime));
    }

    public void RecolectarArgumentosItemsSecuencia73()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia7.TiempoPartidaItemsSecuencia73();
        string itemNameItemsSecuencia6 = _myManagerItemsSecuencia7.itemNameItemSecuencia73();
        string[] softskillItemsSecuencia6 = _myManagerItemsSecuencia7.softskillItemsSecuencia73();
        int type = _myManagerItemsSecuencia7.typeItemsSecuencia73();
        float[] puntuacionItemsSecuencia6 = _myManagerItemsSecuencia7.puntuacionItemSecuencia73();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia6, softskillItemsSecuencia6, type, puntuacionItemsSecuencia6, totalTime));
    }



    #endregion

    #region MethodsConnectItemsSecuencia8
    public void RecolectarArgumentosItemsSecuencia8()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia8.TiempoPartidaItemsSecuencia8();
        string itemNameItemsSecuencia7 = _myManagerItemsSecuencia8.itemNameItemSecuencia8();
        string[] softskillItemsSecuencia7 = _myManagerItemsSecuencia8.softskillItemsSecuencia7();
        int type = _myManagerItemsSecuencia8.typeItemsSecuencia8();
        float[] puntuacionItemsSecuencia5 = _myManagerItemsSecuencia8.puntuacionItemSecuencia8();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia7, softskillItemsSecuencia7, type, puntuacionItemsSecuencia5, totalTime));
    }

    public void RecolectarArgumentosItemsSecuencia82()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia8.TiempoPartidaItemsSecuencia82();
        string itemNameItemsSecuencia8 = _myManagerItemsSecuencia8.itemNameItemSecuencia82();
        string[] softskillItemsSecuencia8 = _myManagerItemsSecuencia8.softskillItemsSecuencia82();
        int type = _myManagerItemsSecuencia8.typeItemsSecuencia82();
        float[] puntuacionItemsSecuencia8 = _myManagerItemsSecuencia8.puntuacionItemSecuencia82();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia8, softskillItemsSecuencia8, type, puntuacionItemsSecuencia8, totalTime));
    }





    #endregion

    #region MethodsConnectItemsSecuencia9
    public void RecolectarArgumentosItemsSecuencia9()
    {
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();

        int totalTime = _myManagerItemsSecuencia9.TiempoPartidaItemsSecuencia9();
        string itemNameItemsSecuencia7 = _myManagerItemsSecuencia9.itemNameItemSecuencia9();
        string[] softskillItemsSecuencia7 = _myManagerItemsSecuencia9.softskillItemsSecuencia9();
        int type = _myManagerItemsSecuencia9.typeItemsSecuencia9();
        float[] puntuacionItemsSecuencia5 = _myManagerItemsSecuencia9.puntuacionItemSecuencia9();

        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        //access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestCarasMongoDB(itemNameItemsSecuencia7, softskillItemsSecuencia7, type, puntuacionItemsSecuencia5, totalTime));
    }

    #endregion

    //method to connect the face method with put
    [System.Obsolete]
    IEnumerator PutTestCarasMongoDB(string itemNameCaras, string[] softskillCaras, int type, float[] puntuacionCaras, int totalTime)
    {


        string uri = $"{baseUrl + "Users/me/gameData/item"}";


        string softskillCarasjoin = string.Join(",", softskillCaras);
        string puntuacionCarasjoin = puntuacionCaras[0].ToString("0.0", CultureInfo.InvariantCulture);

        string body2 = $"{{ \"itemName\": \"{itemNameCaras}\", \"softSkill\": [\"{softskillCarasjoin}\"], \"type\": {type}, \"puntuacion\": [{puntuacionCarasjoin}], \"totalTime\": {totalTime} }}";

        Debug.Log(body2);

        using (UnityWebRequest request = UnityWebRequest.Put(uri, body2))
        {
            request.SetRequestHeader("Authorization", "Bearer " + access_token);
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();


            if (request.isNetworkError || request.isHttpError)
            {
                //outputArea.text = request.error;
                Debug.Log(request.error);
            }
            else
            {
                //outputArea.text = request.downloadHandler.text;
                Debug.Log("BIEN");
            }
        }
    }

    public void EndGame()
    {
        StartCoroutine(GetEndGame());
    }

    public IEnumerator GetEndGame()
    {
        access_token = _myUIManagerLogin.GetAccessToken();
        string uri = $"{baseUrl + "Users/me/endGame"}";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            //porque tiene candado necesita token con acceso 
            request.SetRequestHeader("Authorization", "Bearer " + access_token);
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
            {
               Debug.Log(request.error);
            }
            else
            {
                Debug.Log("bien");
            }
        }
    }
}
