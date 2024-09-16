using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2_6 : MonoBehaviour
{
    [SerializeField] int punto1 = 17;
    [SerializeField] int punto2= 24;
    [SerializeField] int punto3 = 36;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Puntuaciones");
        Debug.Log("Puntuacion1"+ punto1);
        Debug.Log("Puntuacion2"+ punto2);
        Debug.Log("Puntuacion3"+ punto3);

        float media = (punto1 + punto2 + punto3) / 3.0f;

        Debug.Log("Media de puntuaciones " + media);







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
