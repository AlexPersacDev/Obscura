using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathMap : MonoBehaviour
{
    //[SerializeField] List<Material> map; //me creo una lista de materiales para cambiarlos
    Renderer rend;
    [SerializeField] Material[] map;
    Material map00; //y una variable donde guardar la textura inicial
    int index;
    void Start()
    {
        rend = GetComponent<Renderer>();
        map00 = rend.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MapTexture()
    {
        Material actualMat = rend.material; //lo guardo en una variable
        if (index < map.Length) //si mi indice es menor a la longitud del array 
        {
            rend.material = map[index]; //pongo la textura de dicho indice
            index++; //sumo 1 al indice
        }
        else //si el indice es mayor
            rend.material = map00; //hago que la textura vuelva a la principal
    }

    //Material[] mapArray = map.ToArray(); //saco un array de la lista para recorrerlo
    //Renderer rend = GetComponent<Renderer>(); //accedo al renderer
    //Material actualMat = rend.material;
    //Debug.Log(actualMat);
    //    for (int i = 0; i<mapArray.Length; i++) //recorro el array
    //    {
    //        Debug.Log(map[i]);
    //        if (actualMat == map[i])//compruebo cuál es mi material //no consigo que netre en este if aun siendo iguales 
    //        {
    //            Debug.Log("QQ");
    //            map.RemoveAt(i); //elimino el material de la lista
    //                             //compruebo si el indice actual es nulo
    //            if (map[i] != null) //si no es nulo
    //            {
    //                Debug.Log("rr");
    //                rend.material = map[i]; //le cambio el material
    //            }
    //            else
    //rend.material = map00;
    //        }
    //        else
    //rend.material = map[0];
    //    }
    //    //primero he de saber que material
    //    //despues he de cambiarlo al siguiente
}
