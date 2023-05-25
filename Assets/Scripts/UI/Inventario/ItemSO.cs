using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects/Item")]
public class ItemSO : ScriptableObject
{
    public string nombre;
    public GameObject itemPrefab;
    public Sprite icono;
}
