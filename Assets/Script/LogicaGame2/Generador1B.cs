using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1B : MonoBehaviour
{
    public GameObject[] Gene1B;
    private float tiempoEntreLetras;
    private float comienzoDeTiempo = 1.15f; //1.5 1.1 0.7
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
            
            int pos = rn.x;
            Instantiate(Gene1B[pos], this.transform.position, Quaternion.identity);

            
            
            tiempoEntreLetras = comienzoDeTiempo;
        }
        else
        {
            tiempoEntreLetras -= Time.deltaTime;
        }
    }

}
