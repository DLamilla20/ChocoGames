using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador2 : MonoBehaviour
{
    public float velocidadMovimiento;

    public bool estaMoviendose = false;

    //[Header("Animacion")]
    private Animator animator;

    //[Header("Movimiento")]

    //private float movimientohorizontal = 0f;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void FixedUpdate()
    {

        float h = Input.GetAxisRaw("Horizontal");

        estaMoviendose = (h != 0f);
        GetComponent<Rigidbody2D>().velocity = new Vector2(h * velocidadMovimiento, 0);

        animator.SetBool("estaMoviendose", estaMoviendose);
    }
    

    //private void Update()
    //{
    //    animator.SetFloat("Horizontal", Mathf.Abs(movimientohorizontal));
        
    //}
}
