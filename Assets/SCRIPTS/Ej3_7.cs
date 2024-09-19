using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3_7 : MonoBehaviour
{

    [SerializeField] float baseT;
    [SerializeField]float alturaT;

    // Start is called before the first frame update
    void Start()
    {
        float areaT = (baseT * alturaT) / 2; // formula mates (b*a)/2
                                             // 
        Debug.Log("El área es: " + areaT);






    }

  
}
