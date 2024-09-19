using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // como se define un personaje.
    // Propiedades o atributos.
    private string nombre;
    private float vida;
    private float altura;
    private float velocidad;

    public float Vida { get => vida; set => vida = value; }
    public float Altura { get => altura; set => altura = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    // QUÉ es lo que hace un personaje.
    // Los metodos se llaman funcionalidades en POO.
    public void Mover(float x, float y, float z)
    {

    }

   public void Atacar()
   {

   }

    public void Saltar()
           {

           }








}
