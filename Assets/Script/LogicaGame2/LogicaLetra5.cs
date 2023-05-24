using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicaLetra5 : MonoBehaviour
{
    public float velocidad;
    public int contador = 0;
    public bool adentro = false;
    public AudioSource Do;
    // Start is called before the first frame update
 
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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.Do.Play();
            if (adentro) 
            {
                
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
