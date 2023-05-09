using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] float sensibility;
    [SerializeField] GameObject playerBody;

    float rotacionX;


    [SerializeField] Transform interactPos;
    [SerializeField] float radiusInteract;
    [SerializeField] LayerMask interact;

    GameObject currentInteractuable;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   //Oculta el cursor
    }

    void Update()
    {
        CameraMovement();
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
        Debug.DrawRay(ray.origin, ray.direction * 100);
    }
    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawLine(transform.position, new Vector3(0, 0, transform.position.z));
    //}
}
