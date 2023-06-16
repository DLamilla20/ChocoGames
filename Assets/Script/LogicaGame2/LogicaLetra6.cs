using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicaLetra6 : MonoBehaviour
{
    public float velocidad;
    public int contador = 0;
    public bool adentro = false;
    public AudioClip Re;
    private Animator animator;
    private SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("Jugador1").GetComponentInChildren<Animator>();
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

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //this.Re.Play();
            if (adentro) 
            {
                sp.enabled = false;
                ControladorSonido.Instance.EjecutarSonido(Re);
                //ControladorBaile.Instance.Baile(2);
                print("Hola2");
                string cIzquierda = "cIzquierda";
                animator.SetBool(cIzquierda, true);
                StartCoroutine(Espera(cIzquierda));
                GameObject.Find("Casilla2").GetComponent<JugadorLadoB>().PuntajeLadoB();

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
        if(collision.gameObject.tag == "Casilla1B") 
        {
            contador++;         
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Casilla1B") 
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
