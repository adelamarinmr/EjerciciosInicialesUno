using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_7 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    //los numeros qquiera

    void Start()
    {
        int menor;  // comparar para encontar el mayor y el menor
        int mayor;

        if(num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }


        else
        {
            menor = num2;
            mayor = num1;
        }


        for(int i=menor; i<=mayor; i++)
        {
            Debug.Log(i);
        }


    }










}
