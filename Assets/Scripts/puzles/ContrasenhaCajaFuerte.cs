using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ContrasenhaCajaFuerte : MonoBehaviour
{
    string contra = "3185";
    string num = null;
    int index = 0;

    [SerializeField] GameObject puertaCajaFuerte;

    [SerializeField] CinemachineVirtualCamera playerLook;
    [SerializeField] CinemachineVirtualCamera zoomCajaFuerte;
    [SerializeField] GameObject canvasContra;

    [SerializeField] GameObject cajaFuerte;

    [SerializeField] Animator animRueda;

    private void Start()
    {
        animRueda = GetComponent<Animator>();
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
            //puertaCajaFuerte.transform.eulerAngles = new Vector3(0, 150, 0);//se rota

            //cambia la camara
            playerLook.gameObject.SetActive(true);
            zoomCajaFuerte.gameObject.SetActive(false); 
            //se vuelve a desacvtivar el cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
            //se desactiva el canvas de la contraseña
            canvasContra.SetActive(false);

            cajaFuerte.tag = "Untagged";

            animRueda.SetTrigger("AbriendoCaja");
            //Outline interact= cajaFuerte.GetComponent<Outline>();
            //interact.enabled = true;
        }
        else//se resetea el num
        {
            index++;
            num = null;
        }
    }
    //public void Borrar()
    //{
    //    index++;
    //    num = null;
    //}


}
