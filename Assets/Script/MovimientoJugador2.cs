using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador2 : MonoBehaviour
{
    public float velocidadMovimiento;

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(h * velocidadMovimiento, 0);
    }
}
