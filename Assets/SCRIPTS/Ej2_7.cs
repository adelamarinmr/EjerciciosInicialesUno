using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2_7 : MonoBehaviour
{

    [SerializeField] int oroSegundo =7;

    // Start is called before the first frame update
    void Start()
    {
        int horas = 4;
        int segEnHora = 3600;
        int total = horas * segEnHora;
        int oroTotal=oroSegundo * total;

        Debug.Log("Total unidades oro farmeadas en " + horas + "horas: " + oroTotal);




        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
