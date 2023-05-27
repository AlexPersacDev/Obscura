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
    [SerializeField] CinemachineVirtualCamera zoomCandado2;
    [SerializeField] GameObject canvasCandado2;

    bool haveChestKey;
    bool haveDoorKey;

    [Header("BathMap")]
    BathMap bMap;
    bool iceP;
    [SerializeField] GameObject box;
    Collider doorCol;

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
        baul.GetComponent<Collider>().enabled = false;
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
    public bool DoorKey(GameObject interactuable)
    {
        if (interactuable.CompareTag("DoorKey"))//compruebo si el intecatuable es la llave
        {
            haveDoorKey = true;
        }
        return haveDoorKey;
    }

    public void OpeningDoor(GameObject door)
    {
        Animator doorAnim = door.GetComponent<Animator>();
        doorAnim.SetTrigger("Opening");
        door.layer = 0;
    }

    public void InterctionDrawer(GameObject drawer)
    {
              
    }
    public void InteractuarCandado2()
    {
        playerLook.gameObject.SetActive(false);
        zoomCajaFuerte.gameObject.SetActive(false);
        zoomCandado2.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        canvasCandado2.SetActive(true);
        cM.MirillaInteract(false);
        cM.EnableMirilla();
    }
    public void IcePick()
    {
        bMap.MapTexture();
        iceP = true;
    }
    public void WorkTable()
    {
        if (iceP)
        {
            bMap.MapTexture();
            doorCol.enabled = true;
        }
    }
    public void BathDoor(Collider door)
    {
        bMap.MapTexture();
        Destroy(box);
        doorCol = door;
    }
    public void LetterTable()
    {
        bMap.key.SetActive(true);
        bMap.letter.SetActive(true);
    }

    public void PokerCard(GameObject card)
    {
        Destroy(card);
    }
    public void ObjetoEnInventario(GameObject objetoRecogido)
    {
        //aqui va el metodo del inventario
    }



}
