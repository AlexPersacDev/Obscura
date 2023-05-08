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
        if (Physics.Raycast(ray, radiusInteract, interact))
        {
            Debug.Log("AA");
        }
        else
          Debug.Log("BBB");

        Debug.DrawRay(ray.origin, ray.direction * 100);
    }
    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawLine(transform.position, new Vector3(0, 0, transform.position.z));
    //}
}
