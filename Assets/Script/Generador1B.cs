using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1B : MonoBehaviour
{
    public GameObject[] Gene1B;
    private float tiempoEntreLetras;
    public float comienzoDeTiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoEntreLetras <= 0)
        {
            int random = Random.Range(0, Gene1B.Length);
            Instantiate(Gene1B[random],this.transform.position,Quaternion.identity);

            tiempoEntreLetras = comienzoDeTiempo;
        }
        else
        {
            tiempoEntreLetras -= Time.deltaTime;
        }
    }
}
