using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_4 : MonoBehaviour
{  // hago lo mismo que en el ejercicio 7.2 pero al revés y no declao nada aquí
    // pq lo puedo usar directamente en el método start. pero en vez de
    // poner i++ lo hago al revés pq va descontando

   
    void Start()
    {

        for (int i = 100; i >= 1; i--);
        {
            Debug.Log("i");
        }


    }

    
}
