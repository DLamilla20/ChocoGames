using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1A : MonoBehaviour
{
    public GameObject[] Gene1A;
    private float tiempoEntreLetras;
    private float comienzoDeTiempo = 1.15f;
    public JugadorLadoA pt;
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
            
            int pos = rn.x;
            Instantiate(Gene1A[pos], this.transform.position, Quaternion.identity);

            tiempoEntreLetras = comienzoDeTiempo;

        }
        else
        {
            tiempoEntreLetras -= Time.deltaTime;
        }
    }
}
