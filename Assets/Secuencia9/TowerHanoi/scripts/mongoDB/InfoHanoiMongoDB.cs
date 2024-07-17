using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class InfoHanoiMongoDB : MonoBehaviour
{
    static private InfoItemsSecuenciasMongoDB _instanceItems;
    //conexion con GameManager
    GameManagerHanoi _myGameManagerHanoi;
    UIManagerLogin _myUIManagerLogin;
    string baseUrl = "https://backendingenuity.onrender.com/";
    //por defecto uno puesto a mano
    private string access_token = "";

    static public InfoHanoiMongoDB infoHanoiMongoDB;
    static public InfoHanoiMongoDB GetInstanceManagerItemsSecuencia9()
    {
        return infoHanoiMongoDB;
    }

    private void Awake()
    {
        //si la instancia no existe se hace este script la instancia
        if (infoHanoiMongoDB == null)
        {
            infoHanoiMongoDB = this;
        }
        //si la instancia existe , destruimos la copia
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        //gameManager
        _myGameManagerHanoi = GameManagerHanoi.GetInstance();
        //para recolectar el token
        _myUIManagerLogin = UIManagerLogin.GetInstanceUI();
        _instanceItems = InfoItemsSecuenciasMongoDB.GetIstanceInfoItemsSecuenciasMongoDB();
    }

    [System.Obsolete]
    public void RecolectarArgumentosHanoiI()
    {
        int TotalTime = _myGameManagerHanoi.GetTiempoTotalHanoiRegistrado();
        int numJugadas = _myGameManagerHanoi.GetnumJugadasTotalHanoiRegistrado();
        int numMovimientosIncorrectos = _myGameManagerHanoi.GetnumMovsIncorrectosHanoiRegistrado();
        int numMovimientosOutOfLimits = _myGameManagerHanoi.GetnumMovsOutOfLimitsHanoiRegistrado();
        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutHanoiMongoDB(TotalTime, numJugadas, numMovimientosIncorrectos, numMovimientosOutOfLimits));
        //se hace getMethod de endGame tras esto para terminar
        _instanceItems.EndGame();

    }

    public void RecolectarArgumentosHanoiSinAcabar()
    {
        int TotalTime = 0;
        int numJugadas = 0;
        int numMovimientosIncorrectos = 0;
        int numMovimientosOutOfLimits = 0;
        //recolectar token de script login register
        access_token = _myUIManagerLogin.GetAccessToken();
        //se empieza corrutina hoyosMongoDB
        StartCoroutine(PutHanoiMongoDB(TotalTime, numJugadas, numMovimientosIncorrectos, numMovimientosOutOfLimits));
        //se hace getMethod de endGame tras esto para terminar
        _instanceItems.EndGame();
    }

    [System.Obsolete]
    IEnumerator PutHanoiMongoDB(int totalTime, int numJugadas, int numMovimientosIncorrectos, int numMovimientosOutOfLimits)
    {
        

        string uri = $"{baseUrl + "Users/me/gameData/torreHanoi"}";

        string body2 = $"{{ \"totalTime\": {totalTime}, \"numJugadas\": {numJugadas}, \"numMovimientosIncorrectos\": {numMovimientosIncorrectos},\"numMovimientosOutOfLimits\": {numMovimientosOutOfLimits}}}";

        Debug.Log(body2);

        using (UnityWebRequest request = UnityWebRequest.Put(uri, body2))
        {
            request.SetRequestHeader("Authorization", "Bearer " + access_token);
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();
            /*
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }*/
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
}
