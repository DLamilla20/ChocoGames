using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCollision : MonoBehaviour
{
    public MoverPelota mp;
    public controlPuntaje cp;

    void ReboteConRaqueta(Collision2D c)
    {
        Vector3 posicionPelota = this.transform.position;
        Vector3 posicionJugador = c.gameObject.transform.position;
        float alturaRaqueta = c.collider.bounds.size.x;

        float x;
        if (c.gameObject.name == "Jugador1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (posicionPelota.y - posicionJugador.y ); /// alturaRaqueta;

        this.mp.AumentarContadorGolpes();
        this.mp.MovimientoPelota(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Jugador1" || collision.gameObject.name == "Jugador2")
        {
            this.ReboteConRaqueta(collision);
        }
        else if (collision.gameObject.name == "PisoIzquierdo")
        {
            this.cp.GolJugador2();
            StartCoroutine(this.mp.IniciarPelota(true));
        }
        else if (collision.gameObject.name == "PisoDerecho")
        {
            this.cp.GolJugador1();
            StartCoroutine(this.mp.IniciarPelota(false));
        }
    }
}
