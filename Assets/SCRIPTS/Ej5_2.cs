using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_2 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;


    // Start is called before the first frame update
    void Start()
    {
        if ( numero1 <3 && numero2 <3)
        {
            Debug.Log("Los dos son menores que tres");

        }

        else
        {

            Debug.Log("Uno o los dos no son menores que tres");
        }


        // & es ampersand significa and según la tabla apuntesx lo que sería
        // num1 Y num2


    }























    // Update is called once per frame
    void Update()
    {
        
    }
}
