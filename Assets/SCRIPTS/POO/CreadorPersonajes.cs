using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{

   [SerializeField] int numero;
    string texto = "Hola";
    float deci = 3.14f;
    /* Personaje link = null;*/ // Null es que no le hemos dado valor antes, si no
                                // le das valor no le podemos dar un Debug.Log.
    [SerializeField] Personaje Link;
    [SerializeField] Personaje Mario;

    //Para poder editar el personaje, ponemos el SerializeField delante
    //de Personaje Link


    // Start is called before the first frame update
    void Start()
    {
        Link.Nombre = "Link";
        Link.Velocidad = 100;
        Link.Vida = 100;
        Link.Mover(3,1,0);
        Link.Saltar();
        Link.Atacar();
       
        

    }


}
