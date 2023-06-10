using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoPunto : MonoBehaviour
{
    public AudioSource sonido;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Pelota")
        {
            this.sonido.Play();
        }
    }
}
