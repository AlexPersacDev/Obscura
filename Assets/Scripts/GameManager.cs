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

    public void OpeningBaul(GameObject baul)
    {
        Debug.Log("EE");
        baul.transform.Rotate(transform.eulerAngles, anglesRot);
    }
    public void InteractuarCajaFuerte()
    {
        playerLook.gameObject.SetActive(false);
        zoomCajaFuerte.gameObject.SetActive(true);
        canvasCOntrasenha.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }
}
