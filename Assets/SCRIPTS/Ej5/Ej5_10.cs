using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_10 : MonoBehaviour
{
    [SerializeField] string tipoClima="";

    void Start()
    {
        if (temperatura<=10)
        {
            tipoClima = "Frío";
        }

        else if (temperatura > 10 && temperatura <= 20)
        {
            tipoClima = "Nublado";
        }

        else if (temperatura > 20 && temperatura <= 30)
        {
            tipoClima = "Caluroso";
        }

        else if (temperatura > 30)
        {
            tipoClima = "Tropical";
        }

        Debug.Log("La temperatura es: " + temperatura + "grados");
        Debug.Log("El tipo de clima es: " + tipoClima);
    }

    
}
