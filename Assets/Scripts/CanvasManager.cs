using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialogText;
    [SerializeField] List<string> dialogs;
    int dialogIndex = 0;
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
}
