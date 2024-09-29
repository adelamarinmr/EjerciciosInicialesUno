using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_9 : MonoBehaviour
{
    //Serializado: Significa que el valor del
    // número entero se ingresa desde el Inspector en Unity.
    [SerializeField] int num;

    void Start()
    {
        for (int i = 9; i <= num; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }

        }

    }

// Anidación de IF en FOR
// For- desde 1 hasta el valor num
// If la condición- el bucle para cuando i=num



}
