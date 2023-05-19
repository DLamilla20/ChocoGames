using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador2 : MonoBehaviour
{
    public float velocidadMovimiento;

    [Header("Animacion")]
    private Animator animator;

    [Header("Movimiento")]

    private float movimientohorizontal = 0f;

    private void FixedUpdate()
       

    {

        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(h * velocidadMovimiento, 0);
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetFloat("Horizontal", Mathf.Abs(movimientohorizontal));
        
    }
}
