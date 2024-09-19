using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3_5 : MonoBehaviour
{

    [SerializeField]float radio;
    // Start is called before the first frame update
    void Start()
    {
        float PI = 3.1416f;
        float longitud = 2 * PI * radio;
        float area = PI * radio * radio;

        Debug.Log("La longitud de la circunferencia es: " + longitud);
        Debug.Log("La área de la circunferencia es: " + area);







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
