using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_5 : MonoBehaviour
{
    [SerializeField] int numero;

    // Start is called before the first frame update
    void Start()
    {

        int contador = 1;

        while (contador <= numero)

        Debug.Log("Mostrando numeros " + contador + "contador");
        contador++;
        




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
