using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4_4 : MonoBehaviour
{
    float velocidadKmH = 200f;
    // Start is called before the first frame update
    void Start()
    {
        

        float velocidadMS= ConvertirVel(velocidadKmH);
        Debug.Log(velocidadKmH+"Km/H son: " + velocidadMS+"m/s");
    }

    float ConvertirVel(float velocidadKmH)
    { 
        float conversor= (velocidadKmH/3.6f); // como en el ejercicio 3.6
        return conversor;

    }



}
