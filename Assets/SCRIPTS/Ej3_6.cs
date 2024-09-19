using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3_6 : MonoBehaviour
{

    float velKmH;

    // Start is called before the first frame update
    void Start()
    {
        float velMS = velKmH/3.6f;  // 1kmH son 1000m y 3600seg

        Debug.Log("La vel en m/s es: " + velMS);




    }

    
}
