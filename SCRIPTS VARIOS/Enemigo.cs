using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public string Nombre {  get; private set; }

    public Enemigo(string nombre, int saludInicial)
    {
        Nombre = nombre;
        Debug.Log(Nombre + " ha aparecido. Salud inicial: " + saludInicial);
    }

    public void RecibirAtaque(int DamageAmount)
    {
        Debug.Log(Nombre + " ha recibido " + DamageAmount + " puntos de daño.");
    }
}
