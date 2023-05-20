using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField] CanvasManager cM;
    [SerializeField] GameObject[] PhotosCorck;
    [SerializeField] GameObject[] videosTV;
    int index;

    [SerializeField] float anglesRot;

    [Header("Caja Fuerte")]
    [SerializeField] CinemachineVirtualCamera playerLook;
    [SerializeField] CinemachineVirtualCamera zoomCajaFuerte;
    [SerializeField] GameObject canvasCOntrasenha;

    bool haveChestKey;

    [Header("BathMap")]
    BathMap bMap;

    [Header("Drawer")]
    bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        bMap = FindObjectOfType<BathMap>(); //busco el objeto en escena al ser el unico de dicho tipo
    }   

    // Update is called once per frame
    void Update()
    {
        ChangeBathMapTexture();
    }

    public void ActivatePhoto()
    {
        if (!PhotosCorck[0].activeSelf && !cM.CorutineOn())
        {
            cM.StartCoroutine(cM.GenerateDialogs(2));
        }
        PhotosCorck[index].SetActive(true);//activo la foto en este indice
        videosTV[index].SetActive(true); //y activo las tvs
        index++; //sumo el indice para avanzar en el array
    }

    public void OpeningBaul(GameObject baul)//recojo el baul por entrada
    {
        Animator baulAnim = baul.GetComponent<Animator>();//pillo su animator
        baulAnim.SetTrigger("Opening");//activo la animación
        baul.gameObject.layer = 0; //deja de ser interactuable
    }
    public void InteractuarCajaFuerte()
    {
        playerLook.gameObject.SetActive(false);
        zoomCajaFuerte.gameObject.SetActive(true);
        canvasCOntrasenha.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        cM.MirillaInteract(false);
        cM.EnableMirilla();
    }

    public bool ChestKey(GameObject interactuable)
    {
        if (interactuable.CompareTag("ChestKey"))//compruebo si el intecatuable es la llave
        {
            haveChestKey = true;
        }
        return haveChestKey;
    }

    public void ChangeBathMapTexture() //metodo para cambiar la textura haciendo uso de otro metodo dentro del script de bathmap
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            bMap.MapTexture();
        }
    }

    public void OpeningDoor(GameObject door)
    {
        Animator doorAnim = door.GetComponent<Animator>();
        doorAnim.SetTrigger("Opening");
    }

    public void InterctionDrawer(GameObject drawer)
    {
        Animator drawerAnim = drawer.GetComponent<Animator>();
        if (!isOpen)
        {
            drawerAnim.SetTrigger("Opening");
            isOpen=true;
        }
        else
        {
            drawerAnim.SetTrigger("Close");
            isOpen = false;
        }
    }





}
