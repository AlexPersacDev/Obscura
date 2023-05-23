using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    bool inventarioEnabled;
    [SerializeField] GameObject inventario;
    int allSlots;
    int enabledSlots;
    GameObject[] slots;
    [SerializeField] GameObject slotHolder;

    void Start()
    {
        allSlots = slotHolder.transform.childCount;
        slots = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slots[i] = slotHolder.transform.GetChild(i).gameObject;
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventarioEnabled = !inventarioEnabled;
        }
        if (inventarioEnabled==true)
        {
            //Debug.Log("Activo");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            inventario.SetActive(true);
        }
        else
        {
            //Debug.Log("inactivo");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
            inventario.SetActive(false);
        }
    }
}
