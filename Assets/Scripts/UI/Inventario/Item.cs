using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int id;
    public string type;//esto alomejor es prescindible
    public Sprite icon;

    [HideInInspector]
    public bool pickedUp;

   
}
