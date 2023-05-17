using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ContrasenhaCajaFuerte : MonoBehaviour
{
    string contra = "3815";
    string num = null;
    int index = 0;

    [SerializeField] GameObject puertaCajaFuerte;

    [SerializeField] CinemachineVirtualCamera playerLook;
    [SerializeField] CinemachineVirtualCamera zoomCajaFuerte;
    [SerializeField] GameObject canvasContra;

    [SerializeField] GameObject cajaFuerte;

    [SerializeField] CanvasManager cM;

    Animator animRueda;

    private void Start()
    {
        animRueda = cajaFuerte.GetComponent<Animator>();
    }
    public void Codigo(string numeros)
    {
        index++;
        num = num + numeros;
        Debug.Log(""+num);
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


}
