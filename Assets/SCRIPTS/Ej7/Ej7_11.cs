using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_11 : MonoBehaviour
{
    // TAbla de multiplicar ej
    [SerializeField] int num;

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(num + "x" + i + "= " + (num * i));
        }


    }
}