using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerHanoi : MonoBehaviour
{
    //singleton
    static private UIManagerHanoi _instanceUIHanoi;

    [SerializeField] private GameObject vfxFireworks;
    [SerializeField] private GameObject ImageWin;
    [SerializeField] private GameObject zoom;


    [SerializeField] private GameObject panelIncorrect;
    [SerializeField] private GameObject panelFueraLimites;

    [SerializeField] private GameObject nextScene;


    private void Awake()
    {
        //si la instancia no existe se hace este script la instancia
        if (_instanceUIHanoi == null)
        {
            _instanceUIHanoi = this;
        }
        //si la instancia existe , destruimos la copia
        else
        {
            Destroy(this.gameObject);
        }
    }

    static public UIManagerHanoi GetInstanceUI()
    {
        return _instanceUIHanoi;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetFireworksWin(bool set)
    {
        
        ImageWin.SetActive(set);
        zoom.GetComponent<DOTweenAnimation>().DORestartById("ZoomOut");
        //boton quit tween
        Invoke("NextScene", 3f);

    }

    private void NextScene()
    {
        nextScene.GetComponent<NextSceneGenericMethod2>().NextScene();
    }


    public void Incorrect()
    {
        panelIncorrect.SetActive(true);
        panelIncorrect.transform.DOScale(new Vector3(1.2f, 1.1f, 0), 0.5f).SetEase(Ease.InOutSine);
        Invoke("QuitIncorrect", 2.5f);
    }

    public void QuitIncorrect()
    {
        panelIncorrect.transform.DOScale(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.InBounce);
        panelIncorrect.SetActive(false);

    }

    public void FueraLimites()
    {
        panelFueraLimites.SetActive(true);
        panelFueraLimites.transform.DOScale(new Vector3(1.2f, 1.1f, 0), 0.5f).SetEase(Ease.InOutSine);
        Invoke("QuitFueraLimites", 2.5f);
    }

    public void QuitFueraLimites()
    {
        panelFueraLimites.transform.DOScale(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.InBounce);
        panelFueraLimites.SetActive(false);

    }
}
