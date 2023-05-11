using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] GameManager gM;


    [SerializeField] float sensibility;
    [SerializeField] GameObject playerBody;

    float rotacionX;


    [SerializeField] Transform interactPos;
    [SerializeField] float radiusInteract;
    [SerializeField] LayerMask interact;

    GameObject currentInteractuable;
    bool interacting;

    GameObject[] Photos = new GameObject[9];
    int pIndex;
    [SerializeField] GameObject Photo1;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   //Oculta el cursor
        Photos[0] = Photo1;
    }

    void Update()
    {
        CameraMovement();
        Interaction();
    }

    void CameraMovement()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //Rotacion cupero
        Vector3 rotacionY = Vector3.up * sensibility * mouseX;
        playerBody.transform.Rotate(rotacionY * Time.deltaTime);

        //Rotacion cabesa
        rotacionX -= sensibility * mouseY * Time.deltaTime;


        rotacionX = Mathf.Clamp(rotacionX, -90, 90);
        transform.localEulerAngles = new Vector3(rotacionX, 0, 0); //afecta solo localmente
        DetectInteractuable();
    }

    void DetectInteractuable()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, radiusInteract, interact)) //si detecto algo con el raycast que tenga la layermas interact
        {
            interacting = true;
            GameObject actualInteractuable = hit.transform.gameObject; //recojo el gameobject detectado 
            //compruebo si tengo guardado un interactuable
            if (!currentInteractuable) //si no tengo
            {
                currentInteractuable = actualInteractuable; //hago que el current seal el objeto detectado
            }
            else//si tengo guardado un interactuable
            {
                currentInteractuable.GetComponent<Outline>().enabled = false; //desactivo el outline del guardado
                currentInteractuable = actualInteractuable; //hago que el current seal el objeto detectado
            }
            currentInteractuable.GetComponent<Outline>().enabled = true; //activo su script;
        }
        else //si no he detctado nada interactuable
        {
            if (currentInteractuable)//compruebo si tengo guardado algo en currentinteractuable
            {
                currentInteractuable.GetComponent<Outline>().enabled = false; //desactivo el outline del guardado
            }
            currentInteractuable = null; //vacio la variable
        }
    }

    void Interaction()
    {
        if (interacting && Input.GetKeyDown(KeyCode.E)) //si el raycast detecta interactuable y pulso E
        {
            if (currentInteractuable.CompareTag("Corck")) //y el tag del interactuable es corck
            {
                if (Photos[pIndex]) //si tengo la foto
                {
                    gM.ActivatePhoto();//la activo
                    //Photos[pIndex] = null; //la elimino para evitar errores
                    pIndex++; //sumo uno mas al indice
                }
            }
            else if (currentInteractuable.CompareTag("Photo"))
            {

            }
        }
    }
}
