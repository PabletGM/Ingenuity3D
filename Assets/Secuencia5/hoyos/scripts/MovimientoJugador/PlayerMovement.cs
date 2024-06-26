using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    GameManager _myGameManager;
    //lista de waypoints a los que se podr� desplazar el jugador
    [SerializeField]
    private Transform[] waypoint;

    [SerializeField]
    private GameObject[] flechas;
    //saber posicion del waypoint
    public Transform target;
    public float speed;
    //mientras no haya llegado a la meta
    private bool movimiento = false;

    [SerializeField]
    private GameObject playerPico;

    [SerializeField]
    private GameObject playerPicoAnimations;

    private bool puedePicar = false;


    #region Picar
    



    public IEnumerator Picar()
    {
        yield return new WaitForSeconds(0.4f);
        playerPicoAnimations.GetComponent<DOTweenAnimation>().DORestartById("Picar");
        yield return new WaitForSeconds(1f);


    }

    public void methodPicar()
    {
        StartCoroutine(Picar());
    }


    #endregion




    // Start is called before the first frame update
    void Update()
    {
        if(movimiento)
        {
            playerPico.transform.position = Vector3.MoveTowards(playerPico.transform.position, target.position, speed);
            playerPico.transform.position = new Vector3(playerPico.transform.position.x, 0,0);

            
            //si ha llegado a la posicion y no puede picar, puedePicar = true
            if (playerPico.transform.position.x >= target.position.x - 0.1f)
            {
                
                movimiento = false;
            }
        }

       
    }

    //pregunta al GameManager que bot�n se ha pulsado y nos lo devuelve
    //una vez que sabemos el boton pulsado cambiamos el waypoint acorde a el
    public void EncontrarBotonPulsado()
    {
       
        SelectedButton instance = _myGameManager.buttonPressed();
        //averiguamos el nombre del gameObject del boton
        string nameButtonPressed = instance.gameObject.name;
        //lo imprimimos por pantalla
        //segun el nombre que tenga el boton seleccionado cambiamos el target a un waypoint diferente
        switch(nameButtonPressed)
        {
            case "Hoyo0":
                
                target = waypoint[0];
                //metodo flechas
                if (flechas[0]!=null)
                {
                    Flechas(flechas[0]);
                }
                
                break;

            case "Hoyo1":
                
                target = waypoint[1];
                if (flechas[1] != null)
                {
                    Flechas(flechas[1]);
                }
                break;

            case "Hoyo2":
                
                target = waypoint[2];
                if (flechas[2] != null)
                {
                    Flechas(flechas[2]);
                }
                break;

            case "Hoyo3":
                
                target = waypoint[3];
                if (flechas[3] != null)
                {
                    Flechas(flechas[3]);
                }
                break;

            case "Hoyo4":
                
                target = waypoint[4];
                if (flechas[4] != null)
                {
                    Flechas(flechas[4]);
                }
                break;

            case "Hoyo5":
                
                target = waypoint[5];
                
                    Flechas(null);
                
                break;

            default:
                
                break;
        }




    }

    private void Flechas(GameObject flechaBuena)
    {
        //si existe flecha buena
        if(flechaBuena!=null)
        {
            foreach(GameObject flecha in flechas)
            {
                //encontramos la buena
                if(flecha== flechaBuena)
                {
                    flecha.SetActive(true);
                }
                else
                {
                    flecha.SetActive(false);
                }
            }
        }
        //sino existe flecha buena se quitan todas
        else
        {
            foreach (GameObject flecha in flechas)
            {  
               flecha.SetActive(false);
            }
        }

       
    }
    
    //comenzamos la corrutina de desplazamiento del player
    public void EmpezarMoverJugador()
    {
        //seg�n que boton haya pulsado debemos cambiar el target
        EncontrarBotonPulsado();
        StartCoroutine(WalkingWaypoint());
       

    }


    //se hacen corrutinas de andar
    public IEnumerator WalkingWaypoint()
    {

            yield return new WaitForSeconds(0f);
        //mientras que no haya llegado a la meta sigue andando
        Invoke("seguirandando", 0f);


        //si ha llegado a la meta se paran las corrutinas
        //else
        //{
        //    StopAllCoroutines();
        //    meta = false;
        //}
    }

    //loop de mover jugador hasta que llegue a la meta
    private void seguirandando()
    {
        movimiento = true;
        MoverJugador();
        EmpezarMoverJugador();
        
        //StartCoroutine(WalkingWaypoint());
    }
    public void MoverJugador()
    {
        //das permiso para que se mueva
        movimiento = true;
        
    }
    private void Start()
    {
        _myGameManager = GameManager.GetInstance();
    }


}
