using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    bool inventarioEnabled;
    [SerializeField] GameObject inventario;
    int allSlots;
    int enabledSlots;
    GameObject[] slots;
    [SerializeField] GameObject slotHolder;

    Item[] itemsArray;
    int itemsCounter = 0;
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
            //Activo
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            inventario.SetActive(true);
        }
        else
        {
            //inactivo
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
            inventario.SetActive(false);
        }
    }
    void AnhadirItem(Item itemAAnhadir)
    {
        int index = 0;
        itemsArray[itemsCounter] = itemAAnhadir;

        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].transform.GetChild(0).GetComponent<Image>().sprite== null)
            {
                index = i;
                break;
            }
        }
        GameObject slotToFill = slots[index].transform.GetChild(0).gameObject;
        CambiarUI(true, slotToFill, itemAAnhadir.misDatos);
        itemsCounter++;
          
    }
    void CambiarUI(bool estado, GameObject slot, ItemSO datos)
    {
        slot.SetActive(estado);
        slot.GetComponent<Image>().sprite = datos.icono;
        ItemSO nuevosDatos = new ItemSO();
        slot.GetComponent<ItemUI>().misDatos = nuevosDatos;
        slot.GetComponent<ItemUI>().misDatos.itemPrefab = datos.itemPrefab;
    }
}

        //es importante q el recolectable sea prefab
        //fernando crea una lista de gO List<GameObject> nosek = new, tambien puede ser un listado de items 
        //en donde se ha interactuado se hace nosek.Add -> lo que clicko lo añado a la lista
        //para anñadirlo al slot, añadir a los assets las imagenes ponerlo como sprite y en cada slot crear un hijo y meter la imagen en el hijo, ponerlo inactivo 
        //hcaer un script "item so" cambiar el mono behaviur por ScriptibleObject y quitar el start y el update, crear serializados un string nombre  y Go itemPrefab y un Sprite icono
        //encima de la clase escribir [CreateAssetMenu(fileName = "ScriptableObjects/Items")]
        //los prefabs van a llevar un script de item que lleve sus datos (serializando un ItemSO)
        // en el inventario serializar un gO array que referencien a los slots y donde se añade el item a la lista poner gameobject nombre =slots[items.count-1].transform.GetChild(0).gameObject
        //nombre.SetActive(true); nombre.getcomponent<Image>.sprite = nombre(itemToadd) (añadir libreria unityEngine.UI)
        //en el script de los prefabs 
        //en un nuevo metodo use item y crear un n uevo script que sea UIItem o algo asi 
        //