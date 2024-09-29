using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // pongo numero pq tiene que estar entre el 0 y 9, hago con if-else

    // Start is called before the first frame update
    void Start()
    {

        if (numero>= 0 && numero<=9)
        { // significa:numero es mayor o igual a 0 AND numero menoroigual a 9

            Debug.Log("El número" + numero + "está entre 0 y 9");
        }

        else
        {
            Debug.Log("El número" + numero + "no está entre el 0 y el 9");
        }


    }







}
