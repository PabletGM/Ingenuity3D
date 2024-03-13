using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Networking;

public class InfoItemsSecuenciasMongoDB : MonoBehaviour
{
    //instance
    static private InfoItemsSecuenciasMongoDB _instanceItems;

    //conexion con Managers
    ManagerTareaCaras _myManagerCaras;


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
        //access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestConfianza1MongoDB(itemNameCaras1, softskillCaras1, type, puntuacionCaras1, totalTime));
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
        //access_token = _myUIManagerLogin.GetAccessToken();
        //access token temporal
        access_token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkdGVydHJlNTlAZ21haWwuY29tIiwiZXhwIjoxNzEwOTIxNTQ3fQ.fgMqT48uaLX49sAuRcxgVu9g9xrNPxWGb6B0LE5cpsI";
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutTestConfianza1MongoDB(itemNameCaras2, softskillCaras2, type2, puntuacionCaras2, totalTime2));
    }
    #endregion


    

   
    //method to connect the face method with put
    [System.Obsolete]
    IEnumerator PutTestConfianza1MongoDB(string itemNameCaras, string[] softskillCaras, int type, float[] puntuacionCaras, int totalTime)
    {


        string uri = $"{baseUrl + "Users/me/gameData/item"}";

        //"itemName": "CONF_2",
        //"softSkill": [  "confianza"],
        //"type": 1,
        //"puntuacion": [1.2]


        string softskillConfianza1join = string.Join(",", softskillCaras);
        string puntuacionConfianza1join = puntuacionCaras[0].ToString("0.0", CultureInfo.InvariantCulture);

        string body2 = $"{{ \"itemName\": \"{itemNameCaras}\", \"softSkill\": [\"{softskillConfianza1join}\"], \"type\": {type}, \"puntuacion\": [{puntuacionConfianza1join}], \"totalTime\": {totalTime} }}";

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
