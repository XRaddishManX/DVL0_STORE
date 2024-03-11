using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorEjemplo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Jugador jugador1 = new Jugador("jugador1", 100);

        jugador1.atacar(new Enemigo("enemigo1", 50));

        jugador1.ReceiveDamage(30);

        jugador1.ReceiveDamage(80);
    }
}
