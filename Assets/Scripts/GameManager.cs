using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] PhotosCorck;
    [SerializeField] GameObject[] videosTV;
    int index;

    [SerializeField] float anglesRot;

    [Header("Caja Fuerte")]
    [SerializeField] CinemachineVirtualCamera playerLook;
    [SerializeField] CinemachineVirtualCamera zoomCajaFuerte;
    [SerializeField] GameObject canvasCOntrasenha;
    bool haveChestKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivatePhoto()
    {

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
        
    }

    public bool ChestKey(GameObject interactuable)
    {
        if (interactuable.CompareTag("ChestKey"))//compruebo si el intecatuable es la llave
        {
            haveChestKey = true;
        }
        return haveChestKey;
    }
}
