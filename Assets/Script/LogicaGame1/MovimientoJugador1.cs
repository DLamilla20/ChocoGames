using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador1 : MonoBehaviour
{
    public float velocidadMovimiento;
    public bool estaMoviendose = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal2");
        estaMoviendose = (h != 0f);
        GetComponent<Rigidbody2D>().velocity = new Vector2(h * velocidadMovimiento, 0);

        animator.SetBool("estaMoviendose", estaMoviendose);
    }
}
