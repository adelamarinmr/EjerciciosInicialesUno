using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_6 : MonoBehaviour
{
    [SerializeField] int numero;


    // Start is called before the first frame update
    void Start()
    {

        int contador = -numero;

        while(contador < numero)
        {
            Debug.Log("Voy subiendo " + contador + "contador");
            contador++;
        }


        for (int i = -numero; i < numero; i++)
        {
            Debug.Log("Voy subiendo" + contador + "contador");
        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
