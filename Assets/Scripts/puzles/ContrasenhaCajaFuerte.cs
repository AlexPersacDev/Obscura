using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ContrasenhaCajaFuerte : MonoBehaviour
{
    //caja fuerte 3815
    //puerta garaje 269

    [SerializeField] string contra;
    string num = null;
    int index = 0;

    [SerializeField] GameObject puertaCajaFuerte;

    [SerializeField] CinemachineVirtualCamera playerLook;
    [SerializeField] CinemachineVirtualCamera zoomCajaFuerte;
    [SerializeField] GameObject canvasContra;

    [SerializeField] GameObject cajaFuerte;

    [SerializeField] CanvasManager cM;

    Animator animRueda;

    Animator animCajaFuerte;
    [SerializeField] GameObject currentInteractuable;

    private void Start()
    {
        animRueda = cajaFuerte.GetComponent<Animator>();
        //animCajaFuerte = cajaFuerte.GetComponent<Animator>();
    }
    public void Codigo(string numeros)
    {
        index++;
        num = num + numeros;
        
    }
    public void Enter()
    {
        if (num == contra)//se abre la caja fuerte
        {

            ////cambia la camara
            //playerLook.gameObject.SetActive(true);
            //zoomCajaFuerte.gameObject.SetActive(false); 
            ////se vuelve a desacvtivar el cursor
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = false;
            ////se desactiva el canvas de la contraseña
            //canvasContra.SetActive(false);
            Salida();


            //hago q deje de ser interactuable
            cajaFuerte.layer = 0;

            //animacion manivela + abrirse
            animRueda.SetTrigger("AbriendoCaja");
             Collider safeColl = currentInteractuable.GetComponent<Collider>();
            safeColl.enabled = false;
        }
        else//se resetea el num
        {
            index++;
            num = null;
        }
    }
    public void Salida()
    {
        //cambia la camara
        playerLook.gameObject.SetActive(true);
        zoomCajaFuerte.gameObject.SetActive(false);
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
}
