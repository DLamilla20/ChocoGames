using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1B : MonoBehaviour
{
    public GameObject[] Gene1B;
    private float tiempoEntreLetras;
    private float comienzoDeTiempo = 1.5f; //1.5 1.1 0.7
    public JugadorLadoB pt;
    public RandomNumero rn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoEntreLetras <= 0)
        {
            //int random = Random.Range(0, Gene1B.Length);
            //Instantiate(Gene1B[random],this.transform.position,Quaternion.identity);
            int pos = rn.x;
            Instantiate(Gene1B[pos], this.transform.position, Quaternion.identity);

            //int pts = pt.puntaje;
            //if (pts <= 10)
            //{
            //    comienzoDeTiempo = 1.5f;
            //}
            //else if (pts >= 10 && pts <= 20)
            //{
            //    comienzoDeTiempo = 1.1f;
            //}
            //else
            //{
            //    comienzoDeTiempo = 0.7f;
            //}
            
            
            tiempoEntreLetras = comienzoDeTiempo;
        }
        else
        {
            tiempoEntreLetras -= Time.deltaTime;
        }
    }

}
