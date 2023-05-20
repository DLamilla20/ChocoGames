using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1A : MonoBehaviour
{
    public GameObject[] Gene1A;
    private float tiempoEntreLetras;
    private float comienzoDeTiempo;
    public JugadorLadoA pt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoEntreLetras <= 0)
        {
            int random = Random.Range(0, Gene1A.Length);
            Instantiate(Gene1A[random],this.transform.position,Quaternion.identity);

            int pts = pt.puntaje;
            if (pts <= 10)
            {
                comienzoDeTiempo = 1.5f;
            }
            else if (pts >= 10 && pts <= 20)
            {
                comienzoDeTiempo = 1.1f;
            }
            else
            {
                comienzoDeTiempo = 0.7f;
            }

            tiempoEntreLetras = comienzoDeTiempo;
        }
        else
        {
            tiempoEntreLetras -= Time.deltaTime;
        }
    }
}
