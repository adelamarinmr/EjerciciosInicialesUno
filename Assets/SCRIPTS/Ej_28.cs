using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_28 : MonoBehaviour
{
    [SerializeField] float saludInicial = 120f;
    [SerializeField] float porcentajeVen=3.0f;
    [SerializeField] float vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = saludInicial;

        Turno1();
        Turno2();
        Turno3();
        Turno4();
        Turno5();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void Turno1()
       {
            float daņoVeneno = (porcentajeVen * 1) / 100 * saludInicial;
        vidaActual -= daņoVeneno;
        Debug.Log("Turno1: vida restante= " + vidaActual);
       }

       void Turno2()
       {
          float daņoVeneno = (porcentajeVen * 2) / 100 * saludInicial;
           vidaActual -= daņoVeneno;
           Debug.Log("Turno1: vida restante= " + vidaActual);
       }


       void Turno3()
       {
          float daņoVeneno = (porcentajeVen * 3) / 100 * saludInicial;
          vidaActual -= daņoVeneno;
          Debug.Log("Turno1: vida restante= " + vidaActual);
       }

       void Turno4()
       {
          float daņoVeneno = (porcentajeVen * 4) / 100 * saludInicial;
          vidaActual -= daņoVeneno;
          Debug.Log("Turno1: vida restante= " + vidaActual);
       }

       void Turno5()
       {
          float daņoVeneno = (porcentajeVen * 5) / 100 * saludInicial;
          vidaActual -= daņoVeneno;
          Debug.Log("Turno1: vida restante= " + vidaActual);
       }




}
