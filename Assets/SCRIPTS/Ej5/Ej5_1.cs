using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_1 : MonoBehaviour
{
    [SerializeField] int vidaP1;
    [SerializeField] int vidaP2;


    // Start is called before the first frame update
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
