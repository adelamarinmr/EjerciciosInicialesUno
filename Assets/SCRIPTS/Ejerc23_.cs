using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejerc23_ : MonoBehaviour
{
    int vidas = 10;
    float exp = 2.5f;
    float multi,coci,rest,dob,trip;

    // Start is called before the first frame update
    void Start()
    {
        multi = vidas * exp;
        coci = vidas / exp;
        rest = vidas - exp;
        dob = 2 * exp;
        trip = 3 * exp;

        Debug.Log(multi);
        Debug.Log(coci);
        Debug.Log(rest);
        Debug.Log(dob);
        Debug.Log(trip);
        





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
