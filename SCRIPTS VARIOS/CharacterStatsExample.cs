using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsExample : MonoBehaviour
{
    // Este enum representa los posible estados del personaje
    public enum CharacterState
    {
        Idle, Moving, Attacking, Defending, Dead
    }

    // variable para almacenar el estado actual del personaje
    public CharacterState currentState;


    void Start()
    {
        currentState = CharacterState.Idle;

        changeState(CharacterState.Moving);
        changeState(CharacterState.Attacking);
        changeState(CharacterState.Defending);
    }

    private void changeState(CharacterState newState)
    {
        currentState = newState;

        switch (currentState)
        {
            case CharacterState.Idle:
                Debug.Log("El jugador esta en reposo");
                break;

            case CharacterState.Moving:
                Debug.Log("El jugador se esta moviendo");
                break;

            case CharacterState.Attacking:
                Debug.Log("El jugador esta atacando");
                break;

            case CharacterState.Defending:
                Debug.Log("El jugador se esta defendiendo");
                break;

            case CharacterState.Dead:
                Debug.Log("El jugador ha sido derrotado");
                break;
        }
    }
}
