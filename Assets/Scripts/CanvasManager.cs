using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialogText;
    [SerializeField] List<string> dialogs;
    int dialogIndex = 0;

    [Header("Mirilla")]
    [SerializeField] Texture closedEye;
    [SerializeField] Texture eye;
    [SerializeField] RawImage mirilla;
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void GenerateText()
    {
        dialogText.text = dialogs[dialogIndex];
        dialogIndex++;
    }

    public void MirillaInteract(bool interacting)
    {
        if (interacting)
        {
            mirilla.texture = closedEye;
        }
        else
            mirilla.texture = eye;
    }
    public void EnableMirilla()//esto es pa q se quite la mirilla
    {
        if (mirilla.IsActive()) //Si la mirilla esta activada
        {
            mirilla.gameObject.SetActive(false); //la desactivo
        }
        else //si no está activada
        {
            Debug.Log("EE");
            mirilla.gameObject.SetActive(true); //la activo
        }
    }
}
