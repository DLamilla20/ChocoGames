using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ParedFinalB : MonoBehaviour
{
    public GameObject Stop;

    public int intentos;  //uno
    private int contadorB;//montes de mrd

    public bool completo = false;
    public GameObject texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI intentoB = this.texto.GetComponent<TextMeshProUGUI>();
        intentoB.text = this.intentos.ToString();


        if (contadorB == 2)
        {
            completo = true;


            //SceneManager.LoadScene(3);

        }
        else
        {
            completo = false;
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Letra1B")
        {
            contadorB++;
            
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Letra1B")
        {
            contadorB--;


        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Letra1B")
        {
            if (completo)
            {
                intentos += 1;
                print("Intento " + intentos);
                if (intentos == 3)
                {
                    print("Sin vidas");
                    SceneManager.LoadScene(3);
                }

            }
            
            print("Estuvo aqui");
        }
    }
}
