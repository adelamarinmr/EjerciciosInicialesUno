using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_5 : MonoBehaviour
{
    [SerializeField] int nivelPer;


    // Start is called before the first frame update
    void Start()
    {

        // para ver si es par o impar uso % para resto de división junto
        // con == que es AND

        if (nivelPer % 4 == 0)
        {

            Debug.Log("El nivel de " + nivelPer + " es par");
        }


        else
        {
            Debug.Log("El nivel de" + nivelPer + "es impar");
        }






    }

    
}
