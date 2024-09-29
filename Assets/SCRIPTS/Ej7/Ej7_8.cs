using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_8 : MonoBehaviour
{
    // He copiado el 7.7 y he cambiado lo que pedía :)

    [SerializeField] int num1;
    [SerializeField] int num2;
    //los numeros qquiera

    void Start()
    {
        int menor;  // comparar para encontar el mayor y el menor
        int mayor;

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }


        else
        {
            menor = num2;
            mayor = num1;
        }


        for (int i = menor; i <= mayor; i++)
        {
            if (i % 2==0) //para ver si es par
            {
                Debug.Log(i);
            }
        }


    }


}
