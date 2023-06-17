using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicaLetra4 : MonoBehaviour
{
    public float velocidad;
    public int contador = 0;
    public bool adentro = false;
    public AudioClip Sol;
    private Animator animator;
    private SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("Jugador2").GetComponentInChildren<Animator>();
        sp = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * velocidad * Time.deltaTime;
        if (contador == 2)
        {
            adentro = true;
        }
        else
        {
            adentro = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (adentro) 
            {
                sp.enabled = false;
                ControladorSonido.Instance.EjecutarSonido(Sol);
                string cFDerecha = "cFDerecha";
                animator.SetBool(cFDerecha, true);
                StartCoroutine(Espera(cFDerecha));
                GameObject.Find("Casilla1").GetComponent<JugadorLadoA>().PuntajeLadoA();               
                Destroy(this.gameObject, 1.26f);
            }
        }
        else if (!adentro)
        {
            Destroy(this.gameObject, 5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Casilla1A") 
        {
            contador++;         
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Casilla1A") 
        {
            contador--;
        }
    }

    public IEnumerator Espera(string tipo)
    {
        yield return new WaitForSeconds(1.2f);
        animator.SetBool(tipo, false);
    }
}
