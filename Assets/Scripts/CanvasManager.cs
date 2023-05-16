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
}
