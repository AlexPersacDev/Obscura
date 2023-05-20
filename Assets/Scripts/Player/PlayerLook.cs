using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] GameManager gM;
    [SerializeField] CanvasManager cM;

    [SerializeField] float sensibility;
    [SerializeField] GameObject playerBody;

    float rotacionX;


    [SerializeField] Transform interactPos;
    [SerializeField] float radiusInteract;
    [SerializeField] LayerMask interact;
    [SerializeField] LayerMask masks;

    GameObject currentInteractuable;
    bool interacting;

    List<GameObject> photos = new List<GameObject>();
    GameObject[] brokenPhotos = new GameObject[3];
    int pIndex;
    [SerializeField] GameObject photo1;
    int contadorTrozos;


    bool firstLookOnCrock = true;
    bool firstLookOnBP = true;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   //Oculta el cursor
        photos.Add(photo1);
    }

    void Update()
    {
        CameraMovement();
        Interaction();
        if (Input.GetKeyUp(KeyCode.E))
        {
            cM.MirillaInteract(false);
        }
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
        GeneratingText();
    }

    void DetectInteractuable()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        //if (Physics.Raycast(ray, radiusInteract, masks))
        //{
        //    interacting = false;
        //    if (currentInteractuable)//compruebo si tengo guardado algo en currentinteractuable
        //    {
        //        currentInteractuable.GetComponent<Outline>().enabled = false; //desactivo el outline del guardado
        //    }
        //    currentInteractuable = null; //vacio la variable
        //}
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
            interacting = false;
            if (currentInteractuable)//compruebo si tengo guardado algo en currentinteractuable
            {
                currentInteractuable.GetComponent<Outline>().enabled = false; //desactivo el outline del guardado
            }
            currentInteractuable = null; //vacio la variable
        }
    }

    void Interaction()
    {
        if (interacting) //si el raycast detecta interactuable 
        {
            if (currentInteractuable.CompareTag("Corck") && firstLookOnCrock && !cM.CorutineOn())//si es la primera vez que miro el corcho
            {
                cM.StartCoroutine(cM.GenerateDialogs(2));
                firstLookOnCrock = false;
            }
            else if (currentInteractuable.CompareTag("BrokenPhoto") && firstLookOnBP && !cM.CorutineOn())
            {
                cM.StartCoroutine(cM.GenerateDialogs(1));
                firstLookOnBP = false;
            }
            else if (Input.GetKeyDown(KeyCode.E)) //y pulso E
            {


                cM.MirillaInteract(true);
                if (currentInteractuable.CompareTag("Corck")) //y el tag del interactuable es corck
                {
                    for (int i = 0; i < photos.Count; i++)//compruebo cuantas fotos tengo 
                    {
                        if (photos[i])//si el espacio tiene una foto, entro
                        {
                            photos.RemoveAt(i);
                            gM.ActivatePhoto(); //Activo el metodo
                        }
                    }
                }
                else if (currentInteractuable.CompareTag("BrokenPhoto")) //si interactuo con algo nombrado como foto
                {
                    for (int i = 0; i < brokenPhotos.Length; i++) //recorro la lista de broken photos
                    {
                        if (!brokenPhotos[i])//si este espacio no esta ocupado
                        {
                            brokenPhotos[i] = currentInteractuable;//relleno el hueco con el objeto actual
                            Destroy(currentInteractuable);//destruyo el pedazo de foto
                            contadorTrozos++;
                            if (contadorTrozos == 3)
                            {
                                photos.Add(photo1);
                            }
                            break;
                        }
                    }
                }
                else if (currentInteractuable.CompareTag("Photo"))//Compruebo si el objeto tiene el tag foto
                {
                    photos.Add(photo1);//añadir uno al array de foto
                    Destroy(currentInteractuable);//deberia eliminarlo de la escena
                }
                else if (currentInteractuable.CompareTag("Baul") && gM.ChestKey(currentInteractuable))//compruebo si se tiene la llave
                {
                    gM.OpeningBaul(currentInteractuable);
                }
                else if (currentInteractuable.CompareTag("CajaFuerte"))
                {
                    //llamo al metodo publico del gm
                    gM.InteractuarCajaFuerte();
                }
                else if (currentInteractuable.CompareTag("ChestKey"))
                {
                    gM.ChestKey(currentInteractuable);//le digo al gm que tengo la llave
                    Destroy(currentInteractuable);
                }
                else if(currentInteractuable.CompareTag("Door"))
                {
                    gM.OpeningDoor(currentInteractuable);
                }
                else if(currentInteractuable.CompareTag("Drawer"))
                {
                    gM.InterctionDrawer(currentInteractuable);
                }
            }
        }
    }
    void GeneratingText()
    {

    }
}
