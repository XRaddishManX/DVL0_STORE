using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiciones : MonoBehaviour
{
    [SerializeField] private bool personajeVivo = true;
    [SerializeField][Range(0, 100)] private float SaludPersonaje = 75.0f;
    [SerializeField] private bool EnCombate = false;

    void Start()
    {
            
    }

    private void DeterminarVidadelPeronaje(float salud)
    {
        if (salud >= 75f)
        {
            Debug.Log("La salud del jugador es alta");
        }
        else if(salud >= 30)
        {
            Debug.Log("La salud del jugador es media");
        }
        else
        {
            Debug.Log("La salud del jugador es baja");
        }
    }

    private void DeterminarEstadodelPErsonaje(bool vivo, bool peleando)
    {
        if(vivo)
        {
            if(peleando)
            {
                Debug.Log("El personaje esta en combate");
            }
            else
            {
                Debug.Log("El peronaje esta explorando");
            }
        } else
        {
            Debug.Log("El jugador ha sido derrotado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
