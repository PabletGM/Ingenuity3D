using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.WebRequestMethods;

public class UIManagerLogin : MonoBehaviour
{
    [SerializeField]
    private GameObject fadeIn;


    //singleton
    static private UIManagerLogin _instanceUILogin;

    private string errorCode = "";

    private string access_tokenEntreEscenas = "";


    #region politicaDePrivacidadRegister
    
    [SerializeField]
    private Toggle dataProtectionToggleRegister;

    [SerializeField]
    private Button botonAvanzaRegister;

    #endregion

    #region politicaDePrivacidadLogin

    [SerializeField]
    private Toggle dataProtectionToggleLogin;

    [SerializeField]
    private Button botonAvanzaLogin;

    #endregion


    #region CambiarPanelLoginRegisterGenderHistory
    [SerializeField]
    private GameObject loginPanel;

    [SerializeField]
    private GameObject registrationPanel;

    [SerializeField]
    private GameObject genderPanelLogin;

    [SerializeField]
    private GameObject HistoryPanelLogin;

    [SerializeField]
    private GameObject genderPanelRegister;

    [SerializeField]
    private GameObject HistoryPanelRegister;


    [SerializeField]
    private GameObject buttonChangeStateLoginToRegister;

    [SerializeField]
    private GameObject buttonChangeStateRegisterToLogin;

    #endregion

    #region InputFieldParametersRegister

    [SerializeField]
    private TMP_InputField userNameRegister;

    [SerializeField]
    private TMP_InputField company;

    [SerializeField]
    private TMP_InputField emailRegister;

    [SerializeField]
    private TMP_InputField emailLogin;

    [SerializeField]
    private TMP_InputField firstName;

    [SerializeField]
    private TMP_InputField lastName;

    [SerializeField]
    private TMP_InputField name;

    [SerializeField]
    private TMP_InputField surname;

    [SerializeField]
    private TMP_InputField IDRegister;




    //[SerializeField]
    //private TMP_InputField age;

    [SerializeField]
    private TMP_InputField passwordRegister;

    [SerializeField]
    private TMP_InputField confirmPasswordRegister;

    private int numeroCaracteresMinContraseñaRegister = 4;



    #endregion

    #region InputFieldParametersLogin

    [SerializeField]
    private TMP_InputField userNameLogin;

    [SerializeField]
    private TMP_InputField passwordLogin;

    [SerializeField]
    private TMP_InputField processIdLogin;

    [SerializeField]
    private TMP_InputField couponCodeLogin;

    [SerializeField]
    private GameObject loading;

    #endregion

    #region Pop-UpsLoginRegisterGO
    [SerializeField]
    private GameObject popUpLoginFallo;
    [SerializeField]
    private GameObject popUpRegisterFallo;
    #endregion

    #region urlConexionMongo

    private string uriBackend = "https://backendingenuity.onrender.com/";

    private string uriRegisterBackend;
    private string uriLoginBackend;
    private string uriRegister = "Users/register";
    private string uriLogin = "Users/login";

    private string uriLoginCoupon = "Users/couponLogin";
    private string uriRegisterCoupon = "Users/registerv2";
    private string uriGenreUpdate = "Users/me/updateInfo";

    #endregion

    
    public string actualGenderLogin;

    public string actualGenderRegister;


    //inicializa uri del register y login
    private void Awake()
    {
        uriRegisterBackend = uriBackend + uriRegister;
        uriLoginBackend = uriBackend + uriLogin;
        //si la instancia no existe se hace este script la instancia
        if (_instanceUILogin == null)
        {
            _instanceUILogin = this;

        }
        //si la instancia existe , destruimos la copia
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
       
    }

    private void Update()
    {
        CheckBoxToggleValueSetButtonAvailableRegister(dataProtectionToggleRegister);
        CheckBoxToggleValueSetButtonAvailableLogin(dataProtectionToggleLogin);
    }

    //instancia
    static public UIManagerLogin GetInstanceUI()
    {
        return _instanceUILogin;
    }

    #region Politica de Privacidad

    public void GoToLinkIngenuityWebPoliticy()
    {
        Application.OpenURL("https://ingenuityhr.es/politica-de-privacidad/");
    }

    public void CheckBoxToggleValueSetButtonAvailableRegister(Toggle change)
    {
        //si todos los campos del register no estan vacios Y CHECKBOX PULSADA
        if (emailRegister.text != "" && name.text != "" && surname.text != "" && IDRegister.text != "" && change.isOn)
        {
            //el valor de que sea interactuable el boton avanza dependerá del valor de la checkbox
            botonAvanzaRegister.interactable = change.isOn;
            //opacidad del boton
            Color color = botonAvanzaRegister.GetComponent<Image>().color;
            color.a = 1f; // 1f es opacidad completa, 0.5f es mitad opacidad
            botonAvanzaRegister.GetComponent<Image>().color = color;
        }
        else
        {
            //el valor de que sea interactuable el boton avanza dependerá del valor de la checkbox
            botonAvanzaRegister.interactable = change.isOn = false;
            //opacidad del boton
            Color color = botonAvanzaRegister.GetComponent<Image>().color;
            color.a =  0.5f; // 1f es opacidad completa, 0.5f es mitad opacidad
            botonAvanzaRegister.GetComponent<Image>().color = color;
        }
        
    }

    public void CheckBoxToggleValueSetButtonAvailableLogin(Toggle change)
    {
        //si todos los campos del register no estan vacios Y CHECKBOX PULSADA
        if ( couponCodeLogin.text != "" && change.isOn )
        {
            //el valor de que sea interactuable el boton avanza dependerá del valor de la checkbox
            botonAvanzaLogin.interactable = change.isOn;
            //opacidad del boton
            Color color = botonAvanzaLogin.GetComponent<Image>().color;
            color.a = 1f; // 1f es opacidad completa, 0.5f es mitad opacidad
            botonAvanzaLogin.GetComponent<Image>().color = color;
        }
        else
        {
            //el valor de que sea interactuable el boton avanza dependerá del valor de la checkbox
            botonAvanzaLogin.interactable = change.isOn = false;
            //opacidad del boton
            Color color = botonAvanzaLogin.GetComponent<Image>().color;
            color.a = 0.5f; // 1f es opacidad completa, 0.5f es mitad opacidad
            botonAvanzaLogin.GetComponent<Image>().color = color;
        }

    }



    #endregion

    #region OpenPanelsMethods
    //quitas el panel de registro y pones el de login
    public void OpenLoginPanel()
    {
        loginPanel.SetActive(true);
        registrationPanel.SetActive(false);
    }

    //quitas el panel de login y pones el de register
    public void OpenRegistrationPanel()
    {
        registrationPanel.SetActive(true);
        loginPanel.SetActive(false);
    }

    public void OpenGenderPanelLogin()
    {
        registrationPanel.SetActive(false);
        loginPanel.SetActive(false);

        genderPanelLogin.SetActive(true);
    }

    public void OpenHistoryPanelLogin()
    {
        registrationPanel.SetActive(false);
        loginPanel.SetActive(false);
        genderPanelLogin.SetActive(false);

        HistoryPanelLogin.SetActive(true);
    }

    public void OpenGenderPanelRegister()
    {
        registrationPanel.SetActive(false);
        loginPanel.SetActive(false);

        genderPanelRegister.SetActive(true);
    }

    public void OpenHistoryPanelRegister()
    {
        registrationPanel.SetActive(false);
        loginPanel.SetActive(false);
        genderPanelRegister.SetActive(false);

        HistoryPanelRegister.SetActive(true);
    }



    #endregion

    #region DebugLoginRegister

    //metodo que escribe parametros de Login
    [Obsolete]
    public void DebugLoginParameters()
    {
        //metodo que envia a la base de datos un post del Login
        StartCoroutine(PostLogin(emailLogin.text, passwordLogin.text));
    }

    //metodo que escribe parametros de Registers
    [Obsolete]
    public void DebugRegisterParameters()
    {
        StartCoroutine(PostRegister(userNameRegister.text, emailRegister.text, passwordRegister.text, company.text));
    }









    //login 1
    public void DebugCouponLogin1()
    {
        StartCoroutine(MethodComprobacionAccessTokenLoginCorrectMethod());
    }

    //Register 1
    public void DebugRegisterCoupon1()
    {
        StartCoroutine(MethodComprobacionAccessTokenRegisterV2CorrectMethod());

    }

    //login gender
    public void DebugCouponLogin2()
    {
        StartCoroutine(GenreLogin());
    }

    //register gender
    public void DebugCouponRegister2()
    {
        StartCoroutine(GenreRegister());
    }

    //login/register game
    public void DebugStartGameLoginCouponParameters()
    {
        //metodo que envia a la base de datos un post del Login
        Debug.Log(couponCodeLogin.text);
        //call the scene
        StartGameCouponLogin();

    }

    

    #endregion

    #region ExecuteLoginRegister

   


    #region Coupon Login_Register


    //1--> comprpobacion access token login token    
    public IEnumerator MethodComprobacionAccessTokenLoginCorrectMethod()
    {
        //correct body format
        string body = $@"{{
            ""couponCode"": ""{couponCodeLogin.text}""
        }}";

        string uri = uriBackend + uriLoginCoupon;

        using (UnityWebRequest request = UnityWebRequest.Post(uri, body, "application/json"))
        {

            //initialize loading
            loading.SetActive(true);

            yield return request.SendWebRequest();

            //quit loading
            loading.SetActive(false);

            if (request.isNetworkError || request.isHttpError)
            {

                errorCode = request.error;
                Debug.Log(errorCode);
                //segunda barrera de seguridad, fallo numerico
                TiposFalloCouponNumerico(errorCode);
            }
            else
            {
                Debug.Log("entra");
                ComprobacionAccessTokenLoginCorrect(request.downloadHandler.text);
                //next login panel
                OpenGenderPanelLogin();
            }
        }
    }

    public IEnumerator MethodComprobacionAccessTokenRegisterV2CorrectMethod()
    {

                    string body = $@"{{
                ""email"": ""{emailRegister.text}"",
                ""firstName"": ""{name.text}"",
                ""lastName"": ""{surname.text}"",
                ""processId"": ""{IDRegister.text}""
            }}";


        string uri = uriBackend + uriRegisterCoupon;

        using (UnityWebRequest request = UnityWebRequest.Post(uri, body, "application/json"))
        {
            //initialize loading
            loading.SetActive(true);

            yield return request.SendWebRequest();

            //quit loading
            loading.SetActive(false);


            if (request.isNetworkError || request.isHttpError)
            {

                errorCode = request.error;
                Debug.Log(errorCode);
                //segunda barrera de seguridad, fallo numerico
                TiposFalloCouponNumerico(errorCode);
            }
            else
            {
                Debug.Log("entra");
                ComprobacionAccessTokenLoginCorrect(request.downloadHandler.text);
                //next Scene
                OpenGenderPanelRegister();
            }
        }
    } 




    //2 --> Elegir Genero 
    public IEnumerator GenreLogin()
    {

        // Cambia esto al valor adecuado de la edad
        string body;

        //correct body format
        body = $@"{{
            ""gender"": ""{actualGenderLogin}""
        }}";

       

        Debug.Log(actualGenderLogin);

        string uri = uriBackend + uriGenreUpdate;

        using (UnityWebRequest request = UnityWebRequest.Put(uri, body))
        {
            request.SetRequestHeader("Authorization", "Bearer " + access_tokenEntreEscenas);
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();
           
            if (request.isNetworkError || request.isHttpError)
            {

                Debug.Log(request.error);
            }
            else
            {
                OpenHistoryPanelLogin();
                Debug.Log("BIEN");
            }
        }
    }

    //2 --> Elegir Genero 
    public IEnumerator GenreRegister()
    {

        // Cambia esto al valor adecuado de la edad
        string body;

        //correct body format
        body = $@"{{
            ""gender"": ""{actualGenderRegister}""
        }}";

        Debug.Log(actualGenderRegister);

        string uri = uriBackend + uriGenreUpdate;

        using (UnityWebRequest request = UnityWebRequest.Put(uri, body))
        {
            request.SetRequestHeader("Authorization", "Bearer " + access_tokenEntreEscenas);
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {

                Debug.Log(request.error);
            }
            else
            {
                OpenHistoryPanelRegister();
                Debug.Log("BIEN");
            }
        }
    }



    //3 --> Coupon Login
    public void StartGameCouponLogin()
    {
        loading.SetActive(true);
        fadeIn.GetComponent<DOTweenAnimation>().DORestartById("FadeIn");
    }


    #endregion

    public void Loading()
    {
        //activamos loading
        loading.SetActive(true);
    }

    [Obsolete]
    IEnumerator PostLogin(string email, string passwordLogin)
    {
        // Crear formulario con los datos, todo en minusculas , porque va predefinido el formulario y username esta vez en minuscula
        Debug.Log(email);
        Debug.Log(passwordLogin);
        WWWForm form = new WWWForm();
        form.AddField("username", email);
        form.AddField("password", passwordLogin);


        using (UnityWebRequest request = UnityWebRequest.Post(uriLoginBackend, form))
        {

            yield return request.SendWebRequest();

            //primera barrera de seguridad, para ver fallo
            TipoFalloDetailLogin(request.downloadHandler.text);

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log(request.error);
                Debug.Log("holaaa");
                errorCode = request.error;
                //segunda barrera de seguridad, fallo numerico
                TiposFalloLoginNumero(errorCode);
            }
            else
            {

                ComprobacionAccessTokenLoginCorrect(request.downloadHandler.text);
                //en caso de que sea correcto nos movemos a escena hoyos
                //SceneManager.LoadScene("EscenaInicial3EnRaya");
                Debug.Log("login hecho");
                //LevelLoader.LoadLevel("tareaCaras2");
                StartCoroutine(CreateNewGame());
            }
        }
    }

    [Obsolete]
    IEnumerator PostRegister(string userNameRegister, string email, string passwordRegister, string company)
    {

            // Cambia esto al valor adecuado de la edad
            string body;
           
        Debug.Log(email);
            body = $@"{{
                        ""email"": ""{email}"",
                        ""firstName"": ""{firstName}"",
                        ""lastName"": ""{lastName}"",
                        ""password"": ""{passwordRegister}""
                    }}";

        using (UnityWebRequest request = UnityWebRequest.Post(uriRegisterBackend, body, "application/json"))
        {
            yield return request.SendWebRequest();
              

            //primera barrera de seguridad para ver fallo
            TipoFalloDetailRegister(request.downloadHandler.text);

            //si es incorrecto, esto es si solicitud no llega a base de datos
            if (request.isNetworkError || request.isHttpError)
            {  
                //ponemos errorCode
                errorCode = request.error;
                TiposFalloRegisterNumerico(errorCode);
                Debug.Log(errorCode);
            }
            //si la solicitud llega a base de datos vemos el texto que devuelve
            else
            {
                    
                //comprobamos si es correcto el register
                Comprobacion201RegisterCorrect(request.downloadHandler.text);
                //vamos al login
                Invoke("OpenLoginPanel", 1f);
                    
            }
        }

    }


   
    

    #endregion




    #region ComprobationLoginRegisterCorrect
    //metodo que mira a ver si lo que ha devuelto el register es un codigo 201, esto es register correct
    public void Comprobacion201RegisterCorrect(string registerCorrect)
    {

        // Deserializar el JSON usando JsonUtility
        JsonResponseData response = JsonUtility.FromJson<JsonResponseData>(registerCorrect);

        // Acceder al valor del campo status_code
        int statusCode = response.status_code;
        //si devuelve 201 es correcto
        if(statusCode == 201)
        {
            errorCode = "Status Code: " + statusCode;
            Debug.Log("Status Code: " + statusCode);
        }
        

    }

    //metodo que mira a ver si lo que ha devuelto el register es un codigo 201, esto es register correct
    public void ComprobacionAccessTokenLoginCorrect(string loginCorrect)
    {
        // Deserializar el JSON usando JsonUtility
        JsonResponseData response = JsonUtility.FromJson<JsonResponseData>(loginCorrect);

        // Acceder al valor del campo status_code
        string token = response.access_token;
        SetAccessToken(token);

        Debug.Log("Access token: " + "" + token + "");

    }


    #endregion


    #region TiposLoginIncorrecto
        //metodo que mira a ver si lo que ha devuelto el register es un codigo 201, esto es register correct
        public void TipoFalloDetailLogin(string detailText)
        {
            // Deserializar el JSON usando JsonUtility
            JsonResponseData response = JsonUtility.FromJson<JsonResponseData>(detailText);
            // Acceder al valor del campo detail
            string detail = response.detail;

            //es que es correcto el login
            if(detail==null)
            {
                Debug.Log("El login es correcto, cargando...");
                LoginCorrecto(detail);
            }

            //Segun el detail lo clasificamos de 3 maneras
            switch (detail)
            {

                //significa que la contraseña es incorrecta
                case "Incorrect password":
                    Debug.Log("La contraseña es incorrecta, pruebe otra vez...");
                    ContraseñaIncorrecta(detail);
                    break;

                //significa que el usuario está mal escrito, si pones contraseña y usuario mal, te salta este
                case "User not found":
                    Debug.Log("El usuario está mal escrito...");
                    UsuarioIncorrecto(detail);
                    break;

                default:
                    Console.WriteLine("It's something else.");
                    break;
            }

        }

        //metodo que escribe por pantalla contraseña incorrecta
        public void ContraseñaIncorrecta(string mensaje)
        {
            CambiarMensajeLogin(mensaje);
            
        }

        //metodo que escribe por pantalla usuario incorrecta
        public void UsuarioIncorrecto(string mensaje)
        {
            CambiarMensajeLogin(mensaje);
        }

        //metodo que escribe por pantalla login correcto
        public void LoginCorrecto(string mensaje)
        {
            CambiarMensajeLogin(mensaje);
        }

        //switch con tipos de fallo, ahora con numeros, como comprobacion extra
        public void TiposFalloLoginNumero(string errorDevuelto)
        {
                //HTTP / 1.1 401 Unauthorized     contraseña incorrecta
                //HTTP/1.1 404 Not Found          user incorrecto(si ambos estan mal sale este
            switch (errorDevuelto)
            {
                case "HTTP/1.1 401 Unauthorized":
                    ContraseñaIncorrecta("Contraseña incorrecta");
                    break;

                case "HTTP/1.1 404 Not Found":
                    UsuarioIncorrecto("Usuario incorrecto");
                    break;

                default:
                    Console.WriteLine("It's something else.");
                    break;
            }
        }

        

    
    #endregion

    #region TiposRegisterIncorrecto


        public void TipoFalloDetailRegister(string detailText)
        {
            // Deserializar el JSON usando JsonUtility
            JsonResponseData response = JsonUtility.FromJson<JsonResponseData>(detailText);
            // Acceder al valor del campo detail
            string detail = response.detail;
            //Segun el detail lo clasificamos de 3 maneras
            switch (detail)
            {

                //el usuario ya existe y está cogido
                case "The username is already taken":
                    Debug.Log("Usuario ya existe...");
                    UsuarioYaExiste(detail);
                    break;

               
                //cualquier error de creacion del body para hacer solicitud register(por ejemplo username muy corto)
                case "":
                    Debug.Log("error en creacion del usuario, todo minimo 3 caracteres...");
                    ErrorCreacionUsuarioRegister("error en creacion del usuario, todo minimo 3 caracteres...");
                    break;


                //el usuario se ha creado con exito
                case "The user has been created successfully":
                    Debug.Log("The user has been created successfully");
                    RegisterCorrecto(detail);
                    break;
            }

        }


        
        public void TiposFalloRegisterNumerico(string errorCode)
        {
            
            switch (errorCode)
            {
                //usuario ya existe
                case "HTTP/1.1 409 Conflict":
                    //fallo de register porque usuario ya existente
                    Debug.Log("Usuario ya existe");
                    UsuarioYaExiste("Usuario ya existe");
                    break;

                //error en creacion de usuario y solicutud register
                case "HTTP/1.1 422 Unprocessable Entity":
                    Debug.Log("Error en creacion de usuario, que todo tenga 3 caracteres minimo");
                    ErrorCreacionUsuarioRegister("Error, que todo tenga 3 caracteres minimo");
                    break;

                case "Status Code: 201":
                    Debug.Log("BIEN...el register se ha hecho correctamente, ahora login...");
                    RegisterCorrecto("el register se ha hecho correctamente");
                    break;

                case "HTTP/1.1 406 Not Acceptable":
                    Debug.Log("Error desconocido");
                    ErrorCreacionUsuarioRegister("Error 406");
                    break;
                



                default:
                        Console.WriteLine("It's something else.");
                        break;
            }
        }


    public void TiposFalloCouponNumerico(string errorCode)
    {

        switch (errorCode)
        {
            //usuario ya existe
            case "HTTP/1.1 409 Conflict":
                //fallo de register porque usuario ya existente
                Debug.Log("Usuario ya existe");
                UsuarioYaExiste("Usuario ya existe");
                break;

            //error en creacion de usuario y solicutud register
            case "HTTP/1.1 422 Unprocessable Entity":
                Debug.Log("Error en creacion de usuario, que todo tenga 3 caracteres minimo");
                ErrorCreacionUsuarioRegister("Error, que todo tenga 3 caracteres minimo");
                break;

            case "Status Code: 201":
                Debug.Log("BIEN...el register se ha hecho correctamente, ahora login...");
                RegisterCorrecto("el register se ha hecho correctamente");
                break;

            case "HTTP/1.1 406 Not Acceptable":
                Debug.Log("406: No se acepta el formato ");
                ErrorCreacionUsuarioRegister("406: No se acepta el formato");
                break;

            case "HTTP/1.1 304 Not Modified":
                Debug.Log("Error desconocido");
                ErrorCreacionUsuarioRegister("Error 304");
                break;

            case "HTTP/1.1 401 Unauthorized":
                Debug.Log("Codigo ya utilizado");
                ErrorCreacionUsuarioRegister("Codigo ya utilizado");
                break;
                

            case "HTTP/1.1 404 Not Found":
                Debug.Log("incorrecto");
                ErrorCreacionUsuarioRegister("Codigo Incorrecto");
                break;

            default:
                Console.WriteLine("It's something else.");
                break;
        }
    }

    //metodo que escribe por pantalla contraseña incorrecta
        public void UsuarioYaExiste(string mensaje)
        {
            CambiarMensajeRegister(mensaje);
            
        }

        //metodo que escribe por pantalla usuario incorrecta
        public void ErrorCreacionUsuarioRegister(string mensaje)
        {


        #region RegisterExceptions

            #region NameExceptions
                //miramos si está vacío
                if (name.text=="")
                {
                    CambiarMensajeRegister("Porfavor introduce tu nombre");
                }
                else if (ContainsNumbers(name.text))
                {
                    //miramos si nombre tiene solo letras o caracteres invalidos
                    CambiarMensajeRegister("El nombre solo puede contener letras");
                }
                //miramos si tiene minimo 2 caracteres
                else if(!HasMinimumCharacters(name.text,2))
                {
                    //miramos si nombre tiene solo letras o caracteres invalidos
                    CambiarMensajeRegister("El nombre debe contener al menos 2 caracteres");
                }
            #endregion

            #region SurnameExceptions
                //miramos si está vacío
                else if (surname.text == "")
                {
                    CambiarMensajeRegister("Porfavor introduce tu apellido");
                }
                else if (ContainsNumbers(surname.text))
                {
                    //miramos si nombre tiene solo letras o caracteres invalidos
                    CambiarMensajeRegister("El apellido solo puede contener letras");
                }
                //miramos si tiene minimo 2 caracteres
                else if (!HasMinimumCharacters(surname.text, 2))
                {
                    //miramos si nombre tiene solo letras o caracteres invalidos
                    CambiarMensajeRegister("El apellido debe contener al menos 2 caracteres");
                }
           #endregion

            #region mailExceptions
                //miramos si está vacío
                else if (emailRegister.text == "")
                {
                    CambiarMensajeRegister("Porfavor introduce tu email");
                }
                //miramos si es correo valido, si acaba en .com y .es y si tiene @
                else if (!emailRegister.text.Contains("@") || !emailRegister.text.EndsWith(".com") && !emailRegister.text.EndsWith(".es"))
                {
                
                    //miramos si nombre tiene solo letras o caracteres invalidos
                    CambiarMensajeRegister("El email no posee formato correcto");
                }
                //correo ya registrado o ya existe
                //else if ()
                //{
                //    //miramos si nombre tiene solo letras o caracteres invalidos
                //    CambiarMensajeRegister("Correo ya registrado");
                //}
        #endregion

            #region codigoIDExceptions
                //miramos si está vacío
                else if (IDRegister.text == "")
                {
                    CambiarMensajeRegister("Porfavor introduce tu ID");
                }
                //sino esta vacio es que es incorrecto
                else
                {
                    //miramos si nombre tiene solo letras o caracteres invalidos
                    CambiarMensajeRegister("El código es incorrecto");
                }
        #endregion



        #endregion



        #region LoginExceptions
                //distincion de casos, si esta vacio el codigo ID o no
                if (processIdLogin.text == "")
                {
                    CambiarMensajeLogin("Insertar Codigo");
                }
                //no vacio
                else 
                {
                    CambiarMensajeLogin("Código Incorrecto");
                }
                //si es un codigo ya utilizado
                if(mensaje == "Codigo ya utilizado")
                {
                    CambiarMensajeLogin("Código ya utilizado");
                }
            #endregion

        }

        #region Exceptions

            bool ContainsNumbers(string text)
            {
                return Regex.IsMatch(text, @"\d");
            }

            bool HasMinimumCharacters(string text, int minLength)
            {
                return text.Length >= minLength;
            }

    #endregion


    //metodo que escribe por pantalla login correcto
    public void RegisterCorrecto(string mensaje)
        {
            CambiarMensajeRegister(mensaje);
        }

        public void Error406(string mensaje)
        {
            CambiarMensajeRegister(mensaje);
        }

    #endregion

    #region PopUpRegister
        //Activa/Desactiva popUp Login
        public void SetPopUpRegister(bool set)
        {
            popUpRegisterFallo.SetActive(set);
        }

        public void DesactivarPopUpRegister()
        {
            popUpRegisterFallo.SetActive(false);
        }
        
        //Cambiar popUpLogin Mensaje
        public void CambiarMensajeRegister(string newMessage)
        {
            SetPopUpRegister(true);
            popUpRegisterFallo.GetComponentInChildren<TextMeshProUGUI>().text = newMessage;
            Invoke("DesactivarPopUpRegister", 1.5f);
        }
    #endregion

    #region PopUpLogin
        //Activa/Desactiva popUp Login
        public void SetPopUpLogin(bool set)
        {
            popUpLoginFallo.SetActive(set);
        }

        public void DesactivarPopUpLogin()
        {
            popUpLoginFallo.SetActive(false);
        }
        //Cambiar popUpLogin Mensaje
        public void CambiarMensajeLogin(string newMessage)
        {
            SetPopUpLogin(true);
            popUpLoginFallo.GetComponentInChildren<TextMeshProUGUI>().text = newMessage;
            Invoke("DesactivarPopUpLogin", 1.5f);
        }
    #endregion

    #region DevolverPoner_access_token
    public string GetAccessToken()
    {
        return access_tokenEntreEscenas;
    }
    public void SetAccessToken(string newToken)
    {
        access_tokenEntreEscenas = newToken;
    }
    #endregion


    #region Create New Game

    IEnumerator CreateNewGame()
    {
        Debug.Log("entra2");

        string uriStartGameBackend = uriBackend + "Users/me/startGame";

        string body;

        //if there is not processId
        if(processIdLogin.text == "")
        {
             body = $@"{{
                   
                }}";
        }

        else
        {
             body = $@"{{
                        ""processId"": ""{processIdLogin.text}""
              }}";  
        }


        //string body = $"{{ \"processId\": \"{processIdLogin.text}\"}}";

        loading.SetActive(true);

        using (UnityWebRequest request = UnityWebRequest.Post(uriStartGameBackend, body, "application/json"))
        {
            //porque tiene candado necesita token con acceso 
            request.SetRequestHeader("Authorization", "Bearer " + access_tokenEntreEscenas);
            request.SetRequestHeader("Content-Type", "application/json");

            
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(request.error);
                errorCode = request.error;
            }
            else
            {

                SceneManager.LoadScene("9.1");
                //fadeIn.SetActive(true);
                //fadeIn.GetComponent<DOTweenAnimation>().DORestartById("FadeIn");
            }
        }

    }
    #endregion
}


//variables que almacenan comprobaciones de si se ha loggeado bien y registrado bien
[System.Serializable]
public class JsonResponseData
{
    //status code correcto register 201
    public int status_code;
    //token de login para ver que loggea bien
    public string access_token;
    //para coger strings concretos de posibles fallos
    public string detail;

}
