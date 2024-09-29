using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_1 : MonoBehaviour
{
    [SerializeField] int vidaP1;
    [SerializeField] int vidaP2;


    // if-else pq es una comparacióny == era igual a
    void Start()
    {

        if (vidaP1==vidaP2)
        {

            Debug.Log("Los dos tienen la misma vida");

        }

        else
        {

            Debug.Log(" Las vidas son distintas");
        }


    }

    
}
