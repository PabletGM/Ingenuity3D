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


    //method to connect the face method with put
    [System.Obsolete]
    IEnumerator PutTestCarasMongoDB(string itemNameCaras, string[] softskillCaras, int type, float[] puntuacionCaras, int totalTime)
    {


        string uri = $"{baseUrl + "Users/me/gameData/item"}";

        //"itemName": "CONF_2",
        //"softSkill": [  "confianza"],
        //"type": 1,
        //"puntuacion": [1.2]


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
                Debug.Log("ERRORRRRR");
            }
            else
            {
                //outputArea.text = request.downloadHandler.text;
                Debug.Log("BIEN");
            }
        }
    }


}
