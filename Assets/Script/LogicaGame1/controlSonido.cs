using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlSonido : MonoBehaviour
{
    public AudioSource sonido;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Jugador1" || collision.gameObject.name == "Jugador2")
        {
            this.sonido.Play();
        }
    }
}
