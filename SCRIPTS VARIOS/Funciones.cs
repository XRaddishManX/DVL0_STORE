using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int ResultadoSuma = SumarDosNumeros(5, 7);
        Debug.Log("El resultado de la suma es: " + ResultadoSuma);

        int NumeroEvaluado = 10;
        bool esPar = EsnumeroPar(NumeroEvaluado);

        if (esPar)
        {
            Debug.Log(NumeroEvaluado + " es un numero par");
        } else
        {
            Debug.Log(NumeroEvaluado + " no es un numero par");
        }
    }

    private int SumarDosNumeros(int num1, int num2)
    {
        return num1 + num2;
    }

    private bool EsnumeroPar(int numPar)
    {
        return numPar % 2 == 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
