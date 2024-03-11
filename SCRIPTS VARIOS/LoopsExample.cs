using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] ListaDeNumeros = { 3, 7, 12, 5, 9 };
        IterarListadeNumeros(ListaDeNumeros);

        // Parte B - for (print numbers from 1 to 10)
       PrintNumbers1_10();

        // Use for loop to print elements of an array
        string[] NombresJugadores = { "Diego", "El_tortas", "DeathSoul", "Kzuki" };

        PrintPlayerNames(NombresJugadores);
    }

    #region Foreach

    private void IterarListadeNumeros(int[] numeros)
    {
        foreach (int numero in numeros)
        {
            Debug.Log("Número: " + numero);
        }
    }

    #endregion

    #region For - Print numbers 1 to 10

    private void PrintNumbers1_10()
    {
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log("Número: " + i);
        }
    }

    private void PrintPlayerNames(string[] nombres)
    {
        Debug.Log("Lista de jugadores: ");
        for(int i = 0;i <= nombres.Length; i++)
        {
            Debug.Log("Jugador " + (i+1) + ": " + nombres[i]);
        }
    }

    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
