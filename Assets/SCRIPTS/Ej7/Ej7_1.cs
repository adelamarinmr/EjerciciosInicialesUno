using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_1 : MonoBehaviour
{
    [SerializeField] int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El contador sube" + contador + "contador");
        contador++;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
