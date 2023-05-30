using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{

    [Header("Textos")]
    [SerializeField] TextMeshProUGUI dialogText;
    //[SerializeField] string[] dialogs;
    [SerializeField] List<string> dialogs;
    int dialogIndex = 0;
    bool corutineOn;

    [Header("Mirilla")]
    [SerializeField] Texture point;
    [SerializeField] Texture closedEye;
    [SerializeField] Texture eye;
    [SerializeField] RawImage mirilla;



    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void MirillaInteract(bool interacting, bool detecting)
    {
        if (detecting)
        {
            mirilla.texture = eye;

            if (interacting)
            {
                mirilla.texture = closedEye;
            }
            else
                mirilla.texture = eye;
        }
        else
            mirilla.texture = point;
        
    }
    public void EnableMirilla()//esto es pa q se quite la mirilla
    {
        if (mirilla.IsActive()) //Si la mirilla esta activada
        {
            mirilla.gameObject.SetActive(false); //la desactivo
        }
        else //si no está activada
        {
            mirilla.gameObject.SetActive(true); //la activo
        }
    }
    public bool CorutineOn()
    {
        return corutineOn;
    }

    public IEnumerator GenerateDialogs(int index)
    {
        corutineOn = true;
        for (int i = 0; i < index; i++)
        {
            dialogText.text = dialogs[0];
            yield return new WaitForSeconds(4);
            dialogs.RemoveAt(0);
            dialogText.text = "";
        }
        corutineOn = false;
        index = 0;
        //for (int i = 0; i < dialogs.Length; i++)
        //{
        //    dialogText.text = dialogs[dialogIndex];
        //    yield return new WaitForSeconds(4);
        //    dialogIndex++;
        //    //Debug.Log("aa");
        //    //dialogs.RemoveAt(0);
        //    yield return null;
        //}
        StopCoroutine(GenerateDialogs(index));
        
    }
}
