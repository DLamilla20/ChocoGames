using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicaLetra5 : MonoBehaviour
{
    public float velocidad;
    public int contador = 0;
    public bool adentro = false;
    public AudioClip Do;
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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //this.Do.Play();
            if (adentro) 
            {
                ControladorSonido.Instance.EjecutarSonido(Do);
                ControladorBaile.Instance.Baile(1);
                GameObject.Find("Casilla2").GetComponent<JugadorLadoB>().PuntajeLadoB();
                
                
                Destroy(this.gameObject);

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

    
    
}
