using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_3 : MonoBehaviour
{
    [SerializeField] int numeros = 100;

    // Start is called before the first frame update
    void Start()
    {
        while (numeros > 0)
        {
            Debug.Log("Mi contador baja " + numeros + "numeros");
            numeros--;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
