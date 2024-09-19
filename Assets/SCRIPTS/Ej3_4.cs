using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3_4 : MonoBehaviour
{
    [SerializeField] float exp;


    // Start is called before the first frame update
    void Start()
    {
        float LVL = 32 + (9 * exp / 5);
        Debug.Log("El nivel de mi personaje es: " + LVL);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
