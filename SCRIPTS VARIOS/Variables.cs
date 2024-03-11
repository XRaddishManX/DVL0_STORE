using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numeroEntero = 2;
        float numeroDecimal = 3.45f;
        string Texto = "Hola mundo";
        bool esVerdadero = true;

        Debug.Log("Entero: " +  numeroEntero);
        Debug.Log("Decimal: " + numeroDecimal);
        Debug.Log("El texto dice: " + Texto);
        Debug.Log("El booleano es: " + esVerdadero);

        #region// Operaciones aritmeticas


        // Parte B: Operaciones Aritméticas
        int numerol = 20;
        int numero2 = 5;
        double numeroDecimall = 10.5;

        double numeroDecimal2 = 2.5;

        // Operaciones Aritméticas

        int sumaEnteros = numerol + numero2;

        double sumaDecimales = numeroDecimal + numeroDecimal2;

        int restaEnteros = numerol - numero2;

        double restaDecimales = numeroDecimall - numeroDecimal2;

        int multiplicacionEnteros = numerol * numero2;

        double multiplicacionDecimales = numeroDecimall * numeroDecimal2;
        double divisionEnteros = (double)numerol / numero2;

        double divisionDecimales = numeroDecimall / numeroDecimal2;

        // Imprimir resultados

        Debug.Log("Suma de Enteros:" + sumaEnteros);
        Debug.Log("Suma de Decimales: " + sumaDecimales) ;
        Debug.Log("Resta de Enteros: " + restaEnteros);
        Debug.Log("Resta de Decimales: " + restaDecimales);
        Debug.Log("Multiplicación de Enteros: " +multiplicacionEnteros);
        Debug.Log("Multiplicación de Decimales: " + multiplicacionDecimales);
        Debug.Log("División de Enteros: " + divisionEnteros);

        Debug.Log("División de Decimales: " + divisionDecimales);



        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
