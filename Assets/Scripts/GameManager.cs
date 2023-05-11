using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] PhotosCorck;
    int photosIndex;
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
        Debug.Log("EE");
        PhotosCorck[photosIndex].SetActive(true);//activo la foto en este indice
        photosIndex++; //sumo el indice para avanzar en el array
    }
}
