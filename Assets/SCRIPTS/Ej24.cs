using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej24 : MonoBehaviour
{

    int vidas = 8;
    // Start is called before the first frame update
    void Start()
    {

        vidas = vidas + 77;
        Debug.Log("Mis vidas ahora son: " + vidas); 

        vidas -= 3;
        Debug.Log("Mis vidas ahora son: " + vidas);

        vidas *= 4;
        Debug.Log("Mis vidas ahora son: " + vidas);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
