using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_7 : MonoBehaviour
{
    [SerializeField] int velJ1;
    [SerializeField] int velJ2;
    [SerializeField] int velJ3;

    void Start()
    {

        int jugadorMasRapido = VerJugadorMasRapido(velJ1, velJ2, velJ3);

        Debug.Log("El jugador que va primero tiene vel de: " + jugadorMasRapido);

    }

    // noseseguir:(
    
}
