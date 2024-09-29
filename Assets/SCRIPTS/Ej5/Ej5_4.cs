using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_4 : MonoBehaviour
{//ejercicio de división

    [SerializeField] float num1;
    [SerializeField] float num2;


    void Start()
    {
        if (num2 !=0)
        { // pongo if num2 !=0 pq el divisor no puede ser 0
            float result = num1 / num2;

            Debug.Log("El resultado de esta división de" + num1 +
                "entre" + num2 + " es: " + result);

        }

        else
        {
            Debug.Log("Error: el divisor no puede ser cero");
        }








    }

    
}
