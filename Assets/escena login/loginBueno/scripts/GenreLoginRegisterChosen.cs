using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenreLoginRegisterChosen : MonoBehaviour
{
    private string actualGenderLogin;

    private string actualGenderRegister;

    //singleton
    static private GenreLoginRegisterChosen _instanceGenreDontDestroy;

    //singleton
    private void Awake()
    {
      
        //si la instancia no existe se hace este script la instancia
        if (_instanceGenreDontDestroy == null)
        {
            _instanceGenreDontDestroy = this;
            DontDestroyOnLoad(this.gameObject);

        }
        //si la instancia existe , destruimos la copia
        else
        {
            Destroy(this.gameObject);
        }
    }

    static public GenreLoginRegisterChosen GetInstanceUI()
    {
        return _instanceGenreDontDestroy;
    }

    public string GetActualGenderLogin()
    {
        return actualGenderLogin;
    }

    public string GetActualGenderRegister()
    {
        return actualGenderRegister;
    }

    public void SetActualGenderLogin(string newGender)
    {
        actualGenderLogin = newGender;
    }

    public void SetActualGenderRegister(string newGender)
    {
        actualGenderRegister = newGender;
    }
    private void Start()
    {
        //los generos por defecto del login y register si estan vacias se les pone "unknown"
        actualGenderLogin = "male";
        actualGenderRegister = "male";
    }  
}
