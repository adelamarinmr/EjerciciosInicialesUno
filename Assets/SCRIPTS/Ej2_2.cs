using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_ : MonoBehaviour
{
    int vidas = 10;
    float exp=6.8f;
    char carac='c';






    // Start is called before the first frame update
    void Start()
    {

        float resultadoSuma;
        float resultadoResta;

        resultadoSuma = vidas + exp;
        resultadoResta = vidas - exp;

        Debug.Log(resultadoSuma);
        Debug.Log(resultadoResta);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
