using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7_13 : MonoBehaviour
{
    [SerializeField] int num;

    void Start()
    {
        bool primo; primo(num);

        if (primo)
        {
            Debug.Log(num + "es primo");
        }

        else
        {
            Debuug.Log(num + " no es primo");
        }



    }

    // creo que ahora tengo que hacer otro bool con primo, pero
	// no se si hay que anidar y no termino de entender el return aquí


}
