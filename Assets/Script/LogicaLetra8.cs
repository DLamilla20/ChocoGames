using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicaLetra8 : MonoBehaviour
{
    public float velocidad;
    public int contador = 0;
    public bool adentro = false;
    public AudioSource Sol;
    // Start is called before the first frame update
    void Start()
    {

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

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            if (adentro) 
            {
                this.Sol.Play();
                GameObject.Find("Casilla2").GetComponent<JugadorLadoB>().PuntajeLadoB();
                
                Destroy(this.gameObject);
               
            }
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
}
