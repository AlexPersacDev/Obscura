using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ContrasenhaGaraje : MonoBehaviour
{
    
    //puerta garaje 269

    [SerializeField] string contra;
    string num = null;
    int index = 0;

    

    [SerializeField] CinemachineVirtualCamera playerLook;
    [SerializeField] CinemachineVirtualCamera zoomContraGaraje;
    [SerializeField] GameObject canvasContra;

    [SerializeField] GameObject contraGarajeOBJ;

    [SerializeField] CanvasManager cM;

    Animator animRueda;

    Animator animCajaFuerte;

    [SerializeField] GameObject puerta;
    Animator animPuerta;

    int cuentaNums = -1;

    



    private void Start()
    {
        animRueda = contraGarajeOBJ.GetComponent<Animator>();
        animPuerta = puerta.GetComponent<Animator>();
        //animCajaFuerte = cajaFuerte.GetComponent<Animator>();
       
    }
    void Update()
    {
        Enter();
    }
    public void Codigo(string numeros)
    {
        index++;
        cuentaNums++;
        if (cuentaNums == 3)
        {
            num = null;
            num = numeros;
            cuentaNums = 0;
        }
        else
        {

          num += numeros;
        }
        Debug.Log("" + num);
        
    }
    public void Enter()
    {
        if (num == contra)//se abre la caja fuerte
        {

          
            Debug.Log("abierto");
            animPuerta.SetTrigger("Abierto");
            Salida();

            //hago q deje de ser interactuable
            contraGarajeOBJ.layer = 0;

            //animacion manivela + abrirse
            animRueda.SetTrigger("AbriendoCaja");

            
        }

        //else//se resetea el num
        //{
        //    index++;
        //    num = null;
        //}
    }
    
    public void Salida()
    {
        //cambia la camara
        playerLook.gameObject.SetActive(true);
        zoomContraGaraje.gameObject.SetActive(false);
        //se vuelve a desacvtivar el cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        //se desactiva el canvas de la contraseña
        canvasContra.SetActive(false);
        //y quito la mirilla
        cM.EnableMirilla();
    }

    //mil metodos para las anim de los botones

    public void PresionarUno()
    {
        // animCajaFuerte.SetTrigger("1");
        animRueda.SetTrigger("1");
    }
    public void PresionarDos()
    {
        animRueda.SetTrigger("2");
    }
    public void PresionarTres()
    {
        animRueda.SetTrigger("3");
    }
    public void PresionarCuatro()
    {
        animRueda.SetTrigger("4");
    }
    public void PresionarCinco()
    {
        animRueda.SetTrigger("5");
    }
    public void PresionarSeis()
    {
        animRueda.SetTrigger("6");
    }
    public void PresionarSiete()
    {
        animRueda.SetTrigger("7");
   
    }
    public void PresionarOcho()
    {
        animRueda.SetTrigger("8");
    }
    public void PresionarNueve()
    {
        animRueda.SetTrigger("9");
    }
    void ResetearNumero()
    {
        if (cuentaNums > 3)
        {
            num = null;
        }
    }
}
