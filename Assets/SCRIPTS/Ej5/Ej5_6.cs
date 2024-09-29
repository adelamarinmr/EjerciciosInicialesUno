using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_6 : MonoBehaviour
{
    [SerializeField] int nivel;

    void Start()
    {
        if (MultiploDiez(nivel))
        {
            Debug.Log("El nivel " + nivel + "es múltiplo");
        }

        else
        {
            Debug.Log("El nivel " + nivel + " no es múltiplo");
        }

    }

    bool MultiploDiez(int num)
    {
        return numero % 10 == 0; // si es TRUE Sí es múltiplo de 10
    }


}
