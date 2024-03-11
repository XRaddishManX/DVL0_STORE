using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Propiedades del jugador
    public string Nombre {  get; private set; }
    public int Salud {  get; private set; }

    public Jugador(string nombre, int saludInicial)
    {
        Nombre = nombre;
        Salud = saludInicial;
    }

    public void ReceiveDamage(int DamageAmount)
    {
        Salud -= DamageAmount;

        if(Salud <= 0)
        {
            Morir();
        } else
        {
            Debug.Log(Nombre + " ha recibido " + DamageAmount + " de daño. Salud restante: " + Salud);
        }
    }

    public void atacar(Enemigo enemigo)
    {
        Debug.Log(Nombre + " ataca al enemigo " + enemigo.Nombre + ".");
        enemigo.RecibirAtaque(10);
    }

    private void Morir()
    {
        Debug.Log(Nombre + " ha muerto. Fin del juego");
    }
}
