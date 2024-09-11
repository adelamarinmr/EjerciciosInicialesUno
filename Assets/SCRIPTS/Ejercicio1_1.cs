using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    //Declarar variables
    int vida; // por defecto es 0.
    float porcentajeAcierto;
    bool quemado; 
    string explorador;
    char solucionPuzzle;
    int pocion;



    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hola mundo");
        Debug.Log("Este es el primer videojuego de Adela");
        Debug.Log("Estoy aprendiendo C#");

        vida = 8; //Aignar un valor a la variable.
        porcentajeAcierto = 6.8f;
        quemado = false;
        explorador = "Dani Colado";
        solucionPuzzle = 'R';

        vida += 3;
        vida += pocion;

        



    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");
        
        // Porque al estar en play y especificar que van pasando frames,
        // aparecen cada vez.

    }
}
