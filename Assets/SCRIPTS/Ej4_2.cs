using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4_2 : MonoBehaviour
{
    string nombre = "Laura";
    string apellido = "González";
    string apellido2 = "Marín";
    int edad = 20;

    // Start is called before the first frame update
    void Start()
    {

        ConstruirNombre();



    }

    //Hago un metodo para que me salga el nombre

    void ConstruirNombre()
    {

        Debug.Log("Hola sus datos son: " + nombre + " " + apellido + " " + apellido2 + " " + edad);

    }
    
}
