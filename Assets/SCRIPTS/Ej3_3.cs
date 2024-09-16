using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3_3 : MonoBehaviour
{
    [SerializeField] int numero = 1;
    [SerializeField] int doble;
    [SerializeField] int triple;

    // Start is called before the first frame update
    void Start()
    {
        doble = numero * 2;
        triple = numero * 3;

        Debug.Log("El doble de " + numero +" es igual a:" + doble);
        Debug.Log("El triple de " + numero +" es igual a:" + triple);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
